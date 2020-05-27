using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

/// <summary>
/// 
/// </summary>
namespace Fisher.Core {
    public static partial class Fisher {
        public static FisherResult Insert<T>(this IDbConnection connection,T vo) {
            FisherResult result = new FisherResult();
            FisherSchema schema = FisherUtil.ParseSchema(vo.GetType());
            FisherField pkField = null;

            string sqlString = string.Format("insert into [{0}](",schema.SchemaName);
            string valueString = " values(";
            bool isFirstRow = true;
            foreach(FisherField dapperField in schema.Fields) {
                if(dapperField.KEY_SEQ > 0 || dapperField.SqlDbType == SqlDbType.UniqueIdentifier) {   // 自增及UUID类型主键，跳过
                    pkField = dapperField;
                    continue;
                }
                MethodInfo method = schema.MethodInfos.Find(t => t.Name.Equals("get_" + dapperField.Name,StringComparison.CurrentCultureIgnoreCase));
                var getMethodValue = method.Invoke(vo,null);
                if(getMethodValue == null) {    // 忽略null值，对应生成类中必须允许为null对象，也就是指定“int？”属性
                    if(dapperField.AllowDBNull == false) {
                        result.ExecResult = Result.Exception;
                        result.ExecException = new NotAllowDBNullException(string.Format("必填字段{0}数据库不允许为null!",dapperField.Name));
                        break;
                    }
                    continue;
                }

                if(isFirstRow == false) {
                    sqlString += ",";
                    valueString += ",";
                }
                sqlString += "[" + dapperField.Name + "]";
                switch(dapperField.SqlDbType) {
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
                    if(connection.State == ConnectionState.Closed) {
                        connection.Open();
                    }

                    IDbCommand command = connection.CreateCommand();
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
            FisherField dapperField = schema.Fields.Find(t => t.IsPrimaryKey == true);
            string pkFieldName = dapperField.Name;  // 主键名称
            if(dapperField == null) {                                     // 检查主键是否定义
                throw new PrimaryKeyIsNullException(schema.SchemaName);
            }
            string sqlString = "";
            if(pk_Int > 0) {
                if(dapperField.SqlDbType.Equals(SqlDbType.Int) == false) {
                    throw new PrimaryKeyIllegalTypeException(string.Format("{0}应为Int类型",dapperField.Name));
                }
                sqlString = string.Format(" where {0}={1}",pkFieldName,pk_Int);
            } else if(string.IsNullOrEmpty(pk_uuid) == false) {
                if(dapperField.SqlDbType.Equals(SqlDbType.VarChar) == false && dapperField.SqlDbType.Equals(SqlDbType.NVarChar) == false) {
                    throw new PrimaryKeyIllegalTypeException(string.Format("{0}应为VarChar类型",dapperField.Name));
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
            return Select<T>(connection,-1,-1,sqlCondition,orderby,selectFields);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageSize">PageSize</param>
        /// <param name="pageIndex">PageIndex</param>
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
        /// <returns></returns>
        public static FisherResult<T> Select<T>(this IDbConnection connection,int pageSize = 10,int pageIndex = 1,string sqlCondition = null,string orderby = null,params string[] selectFields) where T : new() {
            if(connection.State == ConnectionState.Closed) {
                connection.Open();
            }
            T propertyItem = new T();

            FisherResult<T> result = new FisherResult<T>();
            result.PageSize = pageSize;
            result.PageIndex = pageIndex;

            FisherSchema schema = FisherUtil.ParseSchema(propertyItem.GetType());
            string pkFieldName = schema.Fields.Find(t => t.IsPrimaryKey == true).Name;  // 主键名称
            if(string.IsNullOrEmpty(pkFieldName)) {                                     // 检查主键是否定义
                result.ExecResult = Result.Exception;
                result.ExecException = new PrimaryKeyIsNullException(schema.SchemaName);
            } else {
                string cmdTxt = "select ";
                string countTxt = string.Format("select count({0}) from {1}",pkFieldName,schema.SchemaName);    // 统计数量
                if(selectFields != null) {                                                                      // 检查查询字段是否正确                
                    foreach(string field in selectFields) {
                        FisherField dapperField = schema.Fields.Find(t => t.Name.Equals(field));
                        if(dapperField == null) {                                                               // 非法的查询字段
                            result.ExecResult = Result.Exception;
                            result.ExecException = new IllegalFieldException(string.Format("Illegal Field:\"{0}\"",field));
                            break;
                        }
                        dapperField.QueryOption = QueryOption.Include;
                    }
                }
                if(result.ExecException == null) {  // 没有错误，继续执行
                    cmdTxt += schema.SelectSQLFields;

                    cmdTxt += " from " + schema.SchemaName;
                    if(string.IsNullOrEmpty(sqlCondition) == false) {   // Where条件
                        cmdTxt += " " + sqlCondition;
                        countTxt += "" + sqlCondition;
                    }
                    if(string.IsNullOrEmpty(orderby) == false) {        // Order by条件
                        cmdTxt += " " + orderby;
                    }
                    if(pageIndex > 0 && pageSize > 0) {                  // 分页
                        if(string.IsNullOrEmpty(orderby)) {              // 如果未指定排序，则默认按照主键（PK）排序
                            cmdTxt += " order by " + pkFieldName;
                        }
                        cmdTxt += string.Format(" offset {0} rows fetch next {1} rows only",(pageIndex - 1) * pageSize,pageSize);

                        // 统计分页记录总数
                        IDbCommand countCmd = connection.CreateCommand();
                        countCmd.CommandText = countTxt;
                        var totalRecord = countCmd.ExecuteScalar();
                        result.TotalRecord = FisherUtil.ParseInt(totalRecord);
                    }

                    try {
                        IDbCommand command = connection.CreateCommand();
                        command.CommandText = cmdTxt;
                        List<string> tempList = schema.Fields.Where(t => t.QueryOption.Equals(QueryOption.Include)).Select(t => t.Name).ToList();
                        if(tempList == null || tempList.Count <= 0) {
                            tempList = schema.Fields.Where(t => t.QueryOption.Equals(QueryOption.Exclude) == false).Select(t => t.Name).ToList();
                        }

                        IDataReader dataReader = command.ExecuteReader();
                        while(dataReader.Read()) {
                            T newItem = new T();
                            foreach(string temp in tempList) {
                                var getDBValue = dataReader[temp];
                                if(getDBValue == DBNull.Value) {
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
            }
            return result;
        }
    }
}