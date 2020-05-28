using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

/// <summary>
/// 
/// </summary>
namespace Fisherman.Core {
    public static partial class FisherCore {
        internal static FisherResult Insert<T>(this IDbConnection conn,T vo) {
            FisherResult result = new FisherResult();
            FisherSchema schema = FisherUtil.ParseSchema(vo.GetType());
            FisherField pkField = null;

            string sqlString = string.Format("insert into [{0}](",schema.SchemaName);
            string valueString = " values(";
            bool isFirstRow = true;
            foreach(FisherField fisherField in schema.Fields) {
                if(fisherField.KEY_SEQ > 0 || fisherField.SqlDbType == SqlDbType.UniqueIdentifier) {   // 自增及UUID类型主键，跳过
                    pkField = fisherField;
                    continue;
                }
                MethodInfo method = schema.MethodInfos.Find(t => t.Name.Equals("get_" + fisherField.Name,StringComparison.CurrentCultureIgnoreCase));
                var getMethodValue = method.Invoke(vo,null);
                if(getMethodValue == null) {    // 忽略null值，对应生成类中必须允许为null对象，也就是指定“int？”属性
                    if(fisherField.AllowDBNull == false) {
                        result.ExecResult = Result.Exception;
                        result.ExecException = new FieldNotAllowNull(string.Format("必填字段{0}数据库不允许为null!",fisherField.Name));
                        break;
                    }
                    continue;
                }

                if(isFirstRow == false) {
                    sqlString += ",";
                    valueString += ",";
                }
                sqlString += "[" + fisherField.Name + "]";
                switch(fisherField.SqlDbType) {
                    case SqlDbType.Bit:
                        valueString += FisherUtil.ParseBoolToBit(getMethodValue);
                        break;
                    case SqlDbType.Int:
                    case SqlDbType.BigInt:
                    case SqlDbType.Float:
                    case SqlDbType.Real:
                    case SqlDbType.SmallInt:
                    case SqlDbType.TinyInt:
                        valueString += getMethodValue;
                        break;
                    default:
                        valueString += string.Format("'{0}'",getMethodValue);
                        break;
                }
                isFirstRow = false;
            }
            sqlString += string.Format("){0})",valueString);    // like:insert into [schema]([filedlist...]) values([values...]);
            result.CommondText = sqlString;
            if(result.ExecException == null) {
                try {
                    if(conn.State == ConnectionState.Closed) {
                        conn.Open();
                    }

                    IDbCommand command = conn.CreateCommand();
                    command.CommandText = sqlString;
                    int resultCount = command.ExecuteNonQuery();
                    if(resultCount > 0) {
                        //command.CommandText = string.Format("SELECT IDENT_CURRENT('{0}')",schema.SchemaName);
                        switch(pkField.SqlDbType) {
                            case SqlDbType.Int:
                                command.CommandText = "select scope_identity() ";
                                result.RecentId = FisherUtil.ParseInt(command.ExecuteScalar());
                                break;
                            case SqlDbType.UniqueIdentifier:
                                command.CommandText = "";
                                //todo:UUID暂不实现
                                break;
                        }
                        result.ExecResult = Result.OK;
                    } else {
                        result.ExecResult = Result.Falied;
                    }
                } catch(Exception excCommand) {
                    result.ExecResult = Result.Exception;
                    result.ExecException = excCommand;
                }
            }
            return result;
        }
        public static FisherResult Update<T>(this IDbConnection connection,T item) {
            FisherResult result = new FisherResult();



            return result;
        }
        public static FisherResult Delete<T>(this IDbConnection connection,int id) {
            FisherResult result = new FisherResult();



            return result;
        }
        public static T SingleRow<T>(this IDbConnection connection,int pk_Int = -1,string pk_uuid = null,string sqlCondition = null) where T : new() {
            T propertyItem = new T();
            FisherSchema schema = FisherUtil.ParseSchema(propertyItem.GetType());
            FisherField fisherField = schema.Fields.Find(t => t.IsPrimaryKey == true);
            string pkFieldName = fisherField.Name;  // 主键名称
            if(fisherField == null) {                                     // 检查主键是否定义
                throw new PKIsNull(schema.SchemaName);
            }
            string sqlString = "";
            if(pk_Int > 0) {
                if(fisherField.SqlDbType.Equals(SqlDbType.Int) == false) {
                    throw new IllegalType(string.Format("{0}应为Int类型",fisherField.Name));
                }
                sqlString = string.Format(" where {0}={1}",pkFieldName,pk_Int);
            } else if(string.IsNullOrEmpty(pk_uuid) == false) {
                if(fisherField.SqlDbType.Equals(SqlDbType.VarChar) == false && fisherField.SqlDbType.Equals(SqlDbType.NVarChar) == false) {
                    throw new IllegalType(string.Format("{0}应为VarChar类型",fisherField.Name));
                }
                sqlString = string.Format(" where {0}=\"{1}\"",pkFieldName,pk_uuid);
            } else if(string.IsNullOrEmpty(sqlCondition) == false) {
                sqlString = sqlCondition;
            }

            FisherResult<T> result = Select<T>(connection,sqlString);
            if(result.Result.Count > 0) {
                return result.Result[0];
            } else {
                return propertyItem;
            }
        }


        /// <summary>
        /// execute db Select action，return as Ljk.Dapper.LjkList
        /// </summary>
        /// <example>
        /// <code>
        /// class Program {
        ///     static void Main(string[] args) {
        ///         LjkList&lt;TSysConfiguration&gt; list = null;
        ///         using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
        ///             list = dbConnection.Select&lt;TSysConfiguration&gt;();
        ///         }
        ///     Console.ReadLine();
        ///  }
        /// }
        /// </code>
        /// </example>
        /// <param name="sqlCondition" >
        /// <para>sqlCondition：</para>
        /// <para>Example：" where name="xxx" and code="xxx""</para>
        /// <seealso cref="www.163.com"/>
        /// </param>
        /// <param name="orderby">
        /// <para>sqlOrderby:</para>
        /// <para>Example：" order by id asc[desc]"</para>
        /// </param>
        /// <returns>Ljk.Dapper.LjkList</returns>
        public static FisherResult<T> Select<T>(this IDbConnection connection,string sqlCondition = null,string orderby = null) where T : new() {
            return Select<T>(connection,sqlCondition,orderby,null);
        }
        /// <summary>
        ///  execute db Select action，return as Ljk.Dapper.LjkList
        /// </summary>
        /// <param name="sqlCondition" >
        /// <para>sqlCondition：</para>
        /// <para>Example：" where name="xxx" and code="xxx""</para>
        /// </param>
        /// <param name="orderby">
        /// <para>sqlOrderby:</para>
        /// <para>Example：" order by id asc[desc]"</para>
        /// </param>
        /// <param name="selectFields">
        /// <para>select fields：</para>
        /// <para>Example："id","Name",...</para>
        /// </param>
        /// <returns>Ljk.Dapper.LjkList</returns>
        public static FisherResult<T> Select<T>(this IDbConnection connection,string sqlCondition = null,string orderby = null,params string[] selectFields) where T : new() {
            return Select<T>(connection,sqlCondition,orderby,-1,-1,selectFields);
        }
       
        
        public static FisherResult<T> Select<T>(this IDbConnection conn,string sqlCondition = null,string orderby = null,int pageSize = -1,int pageIndex = -1,params string[] selectFields) where T : new() {
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            T propertyItem = new T();
            string commandText = "";
            string countText = "";

            // 是否启用分页，pageIndex，pageSize需同时满足 > 0
            bool pageEnabled = (pageIndex > 0 && pageSize > 0) ? true : false;

            FisherResult<T> result = new FisherResult<T>();
            result.PageSize = pageSize;
            result.PageIndex = pageIndex;

            FisherSchema schema = FisherUtil.ParseSchema(propertyItem.GetType());
            string pkFieldName = schema.Fields.Find(t => t.IsPrimaryKey == true).Name;  // 主键名称          
            if(string.IsNullOrEmpty(pkFieldName)) {                                     // 检查主键是否定义
                result.ExecResult = Result.Exception;
                result.ExecException = new PKIsNull(schema.SchemaName);
            } else {
                /* **********************************************
                 * 检查用户是否指定查询字段
                 * 如果指定，则按照用户指定的字段执行查询
                 * 如果未指定，则默认查询所有字段
                 * **********************************************
                 */
                if(selectFields != null) {
                    foreach(string field in selectFields) { // 依次检查用户指定的字段是否在表中存在。
                        FisherField fisherField = schema.Fields.Find(t => t.Name.Equals(field));
                        if(fisherField == null) { // 用户指定了非法的字段，也就是指定了不是表中的字段。
                            result.ExecResult = Result.Exception;
                            result.ExecException = new IllegalField(string.Format("Illegal Field:\"{0}\"",field));
                            break;
                        }
                        fisherField.QueryOption = QueryOption.Include; // 标记为Include
                    }
                }
                commandText += string.Format("select {0} from [{1}]",schema.GetIncludeSQLFields,schema.SchemaName);                

                /* ************************************************
                 * 控制查询条件，如果用户指定了查询条件，则以用户的查询条件为准
                 * 在分页的情况下：
                 *     - 如果用户未指定排序方式，则默认按照主键（PK）排序
                 *     - 如果用户指定了排序条件，则以用户指定的排序方式为准
                 * 不分页的情况，以用户实际order by字段为准
                 */
                commandText += " " + sqlCondition; // Where条件，普通查询增加条件

                if(pageEnabled) {
                    // 分页统计记录总数，包括分页查询条件
                    countText = string.Format("select count({0}) from {1} {2}",pkFieldName,schema.SchemaName,sqlCondition);

                    if(string.IsNullOrEmpty(orderby)) { // throw new PaginationNeedOrderBy("分页必须同时指定[Order By xxx] 参数");
                        commandText += " order by " + pkFieldName;
                    } else {
                        commandText += " " + orderby;
                    }
                    commandText += string.Format(" offset {0} rows fetch next {1} rows only",(pageIndex - 1) * pageSize,pageSize);
                    
                    // 统计分页记录总数
                    IDbCommand countCmd = conn.CreateCommand();
                    countCmd.CommandText = countText;
                    var totalRecord = countCmd.ExecuteScalar();
                    result.TotalRecord = FisherUtil.ParseInt(totalRecord);
                } else {
                    commandText += " " + orderby;
                }        

                try {
                    IDbCommand command = conn.CreateCommand();
                    command.CommandText = commandText;
                    result.CommondText = commandText;
                    List<string> includeFields = schema.Fields.Where(t => t.QueryOption.Equals(QueryOption.Include)).Select(t => t.Name).ToList();
                    if(includeFields == null || includeFields.Count <= 0) {
                        includeFields = schema.Fields.Where(t => t.QueryOption.Equals(QueryOption.Exclude) == false).Select(t => t.Name).ToList();
                    }

                    IDataReader dataReader = command.ExecuteReader();
                    while(dataReader.Read()) {
                        T newItem = new T();
                        foreach(string temp in includeFields) {
                            var getDBValue = dataReader[temp];
                            if(getDBValue == DBNull.Value) {    // 忽略DBNull值
                                continue;
                            }
                            MethodInfo setMethod = schema.MethodInfos.Find(t => t.Name.Equals("set_" + temp,StringComparison.CurrentCultureIgnoreCase));
                            setMethod.Invoke(newItem,new object[] { getDBValue });
                        }
                        result.Result.Add(newItem);
                    }
                    dataReader.Close();
                    dataReader = null;
                } catch(Exception excDBCommand) {
                    result.ExecResult = Result.Exception;
                    result.ExecException = excDBCommand;
                }
            }
            return result;
        }
    }
}