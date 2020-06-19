using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fisherman.Core;

namespace Fisherman.Core {
    public static partial class Fisher {
        static string _ConnectionString;

        public static void Set_ConnectionString(string sqlConnectionString) {
            _ConnectionString = sqlConnectionString;
        }
        private static void CheckConnection() {
            if(string.IsNullOrEmpty(_ConnectionString)) {
                throw new ConnectionStringIsNull(FisherMessage.ConnectionStringIsNull.Message);
            }
        }
        public static T SignleRow<T>(int id,params string[] queryFields) where T : new() {
            T item = new T();
            FisherSchema schema = FisherUtil.ParseSchema(item.GetType());
            FisherField pkField = schema.Fields.Find(t => t.KEY_SEQ > 0 || t.SqlDbType == SqlDbType.UniqueIdentifier);
            if(pkField == null) {
                throw new PKIsNull(FisherMessage.PkIsNull.Message);
            }

            string sqlWhere = string.Format(" where {0}={1}",pkField.Name,id);

            FisherResult<T> result = Query<T>(sqlWhere:sqlWhere,sqlOrderBy:null,pageSize:-1,pageIndex:-1,queryFields:queryFields);
            if(result.Result != null && result.Result.Count > 0) {
                item = result.Result[0];
            }
            
            return item;
        }
        /// <summary>
        /// 第一个参数默认为：UUID，也就是VarChar型主键；
        /// <para>当需要采用：" where xxx=xxx"进行查询时，需将defaultIsWhereGrammar参数设为true，也就是：</para>        
        /// <para>1.既可以用主键查询；</para>
        /// <para>2.也可以用where条件查询；</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uuid"></param>
        /// <param name="defaultIsWhereGrammar"></param>
        /// <returns></returns>
        public static T SignleRow<T>(string uuid,bool defaultIsWhereGrammar=false) where T : new() {
            T item = new T();
            return item;
        }
        //public static FisherResult<T> Query<T>(params string[] selectFields)where T:new() {
        //    return Query<T>(null,null,-1,-1,selectFields);
        //}
        //public static FisherResult<T> Query<T>(string sqlWhere,string sqlOrderBy,params string[] selectFields) where T : new() {
        //    return Query<T>(sqlWhere,sqlOrderBy,-1,-1,selectFields);
        //}
        public static FisherResult<T> Query<T>(string sqlWhere=null,string sqlOrderBy=null,int pageSize=-1,int pageIndex=-1,params string[] queryFields) where T : new() {
            CheckConnection();

            FisherResult<T> result = null;
            try {
                using(IDbConnection conn = new SqlConnection(_ConnectionString)) {
                    result = conn.Select<T>(sqlWhere,sqlOrderBy,pageSize,pageIndex,queryFields);

                    if(result.Result != null) {
                        result.Success = Result.True;
                    } else {
                        result.Success = Result.False;
                    }

                    // page count
                    if(pageSize > 0 && pageIndex > 0) {
                        result.TotalPage = result.TotalRecord / result.PageSize;
                        if(result.TotalRecord % result.PageSize > 0) {
                            result.TotalPage++;
                        }
                    }
                }
            } catch(Exception exc) {
                result = new FisherResult<T>();
                result.Success = Result.Exception;
                result.Exception = exc;
            }
            return result;
        }


        public static FisherResult Save<T>(T item){
            CheckConnection();

            FisherResult result = new FisherResult();
            try {
                using(IDbConnection conn = new SqlConnection(_ConnectionString)) {
                    result = conn.Save<T>(item);
                }
            } catch(Exception exc) {
                result.Success = Result.Exception;
                result.Exception = exc;
            }

            return result;
        }
    }
}
