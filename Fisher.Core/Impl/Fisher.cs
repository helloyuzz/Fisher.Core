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
        public static string CommandText {
            get;set;
        }

        public static void SetConnectionString(string sqlConnectionString) {
            _ConnectionString = sqlConnectionString;
        }
        public static FisherResult<T> Query<T>(string sqlWhere = null,string sqlOrderBy = null,int pageSize = 30,int pageIndex = 1,params string[] selectFields) where T : new() {
            if(string.IsNullOrEmpty(_ConnectionString)) {
                throw new ConnectionStringIsNull("连接字符串不能为空");
            }
            FisherResult<T> result = null;
            using(IDbConnection conn = new SqlConnection(_ConnectionString)) {
                result = conn.Select<T>(sqlWhere,sqlOrderBy,pageSize,pageIndex,selectFields);
                CommandText = result.CommondText;
                result.CommondText = "";

                // page count
                if(pageSize > 0 && pageIndex > 0) {
                    result.TotalPage = result.TotalRecord / result.PageSize;
                    if(result.TotalRecord % result.PageSize > 0) {
                        result.TotalPage++;
                    }
                }
            }
            return result;
        }

        public static FisherResult Save<T>(){
            FisherResult result = new FisherResult();


            return result;
        }
    }
}
