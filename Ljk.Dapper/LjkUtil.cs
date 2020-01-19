using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Ljk.Dapper {
    public class LjkUtil {
        internal static string ParseSelectSQLFields<T>(T item) where T : new() {
            string selectSQLFields = "";
            var ljkDapperFlag = item.GetType().GetCustomAttributes<LjkDapperField>();

            PropertyInfo[] propertyInfos = item.GetType().GetProperties();
            foreach(PropertyInfo propertyInfo in propertyInfos) {
                if(string.IsNullOrEmpty(selectSQLFields) == false) {
                    selectSQLFields += ",";
                }
                selectSQLFields += propertyInfo.Name;
            }

            return selectSQLFields;
        }

        /// <summary>
        /// 解析对象vo==>LjkSchema类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static LjkSchema ParseSchema(Type type) {
            LjkSchema schema = new LjkSchema();
            schema.SchemaName = type.Name;
            schema.MethodInfos = type.GetMethods().ToList();

            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach(PropertyInfo propertyInfo in propertyInfos) {
                Attribute[] flags = Attribute.GetCustomAttributes(propertyInfo);
                if(flags.Length > 0) {
                    LjkDapperField dapperFlag = flags[0] as LjkDapperField;
                    schema.Fields.Add(dapperFlag);
                }
            }

            return schema;
        }

        public static int ParseInt(object obj,int defaultValue = -1) {
            int getInt = 0;
            if(obj != null && obj != DBNull.Value) {
                int.TryParse(obj.ToString(),out getInt);
            }
            if(getInt <= 0) {
                getInt = defaultValue;
            }
            return getInt;
        }
        /// <summary>
        /// 解析Boolean类型对数据库bit类型，返回值（bit:0、1）
        /// </summary>
        /// <param name="getMethodValue"></param>
        /// <returns></returns>
        internal static int ParseBoolToBit(object getMethodValue) {
            int bitValue = 0;
            string stringValue = "";
            if(getMethodValue != null && getMethodValue != DBNull.Value) {
                stringValue = getMethodValue.ToString();
            }
            switch(stringValue.ToUpper()) {
                case "TRUE":
                case "YES":
                case "1":
                    stringValue = "1";
                    break;
                default:
                    stringValue = "0";
                    break;
            }
            int.TryParse(stringValue,out bitValue);
            return bitValue;
        }
    }
}
