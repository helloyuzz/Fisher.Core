using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Fisherman.Core {
    public partial class FisherUtil {
        internal static string ParseSelectSQLFields<T>(T item) where T : new() {
            string selectSQLFields = "";
            var fisherFlag = item.GetType().GetCustomAttributes<FisherField>();

            PropertyInfo[] propertyInfos = item.GetType().GetProperties();
            foreach(PropertyInfo propertyInfo in propertyInfos) {
                if(string.IsNullOrEmpty(selectSQLFields) == false) {
                    selectSQLFields += ",";
                }
                selectSQLFields += propertyInfo.Name;
            }

            return selectSQLFields;
        }

        internal static string ParsePkField(Type type) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 解析对象vo==>LjkSchema类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static FisherSchema ParseSchema(Type type) {
            FisherSchema schema = new FisherSchema();
            schema.SchemaName = type.Name;
            schema.MethodInfos = type.GetMethods().ToList();

            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach(PropertyInfo propertyInfo in propertyInfos) {
                Attribute[] flags = Attribute.GetCustomAttributes(propertyInfo);
                if(flags.Length > 0) {
                    FisherField dapperFlag = flags[0] as FisherField;
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


        public static string IngoreNull(object getValue) {
            if(getValue == null || getValue == DBNull.Value) {
                return "";
            }
            return getValue.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string ParseToDbTypeString(SqlDbType type) {
            string dbTypeString = "";

            switch(type) {
                case SqlDbType.NVarChar:
                    dbTypeString = "SqlDbType.NVarChar";
                    break;
                case SqlDbType.Int:
                    dbTypeString = "SqlDbType.Int";
                    break;
                case SqlDbType.Real:
                    dbTypeString = "SqlDbType.Real";
                    break;
                case SqlDbType.DateTime:
                    dbTypeString = "SqlDbType.DateTime";
                    break;
                case SqlDbType.Bit:
                    dbTypeString = "SqlDbType.Bit";
                    break;
                case SqlDbType.Text:
                    dbTypeString = "SqlDbType.Text";
                    break;
                case SqlDbType.NText:
                    dbTypeString = "SqlDbType.NText";
                    break;
                case SqlDbType.Money:
                    dbTypeString = "SqlDbType.Money";
                    break;
                case SqlDbType.Decimal:
                    dbTypeString = "SqlDbType.Decimal";
                    break;
                case SqlDbType.BigInt:
                    dbTypeString = "SqlDbType.BigInt";
                    break;
            }

            return dbTypeString;
        }
        public static string ParseRunTimeDbTypeString(SqlDbType getType) {
            string dbTypeString = "";

            switch(getType) {
                case SqlDbType.UniqueIdentifier:
                case SqlDbType.Char:
                case SqlDbType.VarChar:
                case SqlDbType.NVarChar:
                case SqlDbType.Text:
                case SqlDbType.NText:
                    dbTypeString = "string";
                    break;
                case SqlDbType.Int:
                    dbTypeString = "int?";
                    break;
                case SqlDbType.Float:
                    dbTypeString = "double?";
                    break;
                case SqlDbType.Real:
                case SqlDbType.Money:
                    dbTypeString = "float?";
                    break;
                case SqlDbType.Date:
                case SqlDbType.DateTime:
                    dbTypeString = "DateTime?";
                    break;
                case SqlDbType.Bit:
                    dbTypeString = "bool?";
                    break;
                case SqlDbType.Decimal:
                    dbTypeString = "Decimal?";
                    break;
                case SqlDbType.BigInt:
                    dbTypeString = "long?";
                    break;
            }

            return dbTypeString;
        }
        public static SqlDbType ParseToSqlDbType(string typeName) {
            SqlDbType dbType = SqlDbType.Int;
            switch(typeName.ToLower()) {
                case "uniqueidentifier":
                    dbType = SqlDbType.UniqueIdentifier;
                    break;
                case "char":
                    dbType = SqlDbType.Char;
                    break;
                case "varchar":
                case "nvarchar":
                    dbType = SqlDbType.NVarChar;
                    break;
                case "date":
                    dbType = SqlDbType.Date;
                    break;
                case "datetime":
                    dbType = SqlDbType.DateTime;
                    break;
                case "bit":
                    dbType = SqlDbType.Bit;
                    break;
                case "int":
                    dbType = SqlDbType.Int;
                    break;
                case "real":
                    dbType = SqlDbType.Real;
                    break;
                case "float":
                    dbType = SqlDbType.Float;
                    break;
                case "text":
                    dbType = SqlDbType.Text;
                    break;
                case "ntext":
                    dbType = SqlDbType.NText;
                    break;
                case "money":
                    dbType = SqlDbType.Decimal;
                    break;
                case "bigint":
                    dbType = SqlDbType.BigInt;
                    break;
                case "decimal":
                    dbType = SqlDbType.Decimal;
                    break;
            }
            return dbType;
        }

        public static int ParseInt(object obj) {
            int value;
            int.TryParse(IngoreNull(obj),out value);
            return value;
        }

        public static bool ParseBool(object v) {
            bool parseValue = false;

            string text = IngoreNull(v);
            switch(text.ToUpper()) {
                case "NO":
                case "FALSE":
                case "0":
                    parseValue = false;
                    break;
                case "YES":
                case "TRUE":
                case "1":
                    parseValue = true;
                    break;
            }


            return parseValue;
        }
    }
}
