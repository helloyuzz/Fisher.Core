using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace My.Dapper {
    public class MySchema {
        public string SchemaName { get; set; }
        public List<MethodInfo> MethodInfos { get; set; }
        public List<MyDapperField> Fields { get; set; } = new List<MyDapperField>();
        public string SelectSQLFields {
            get {
                string _temp = "";
                List<MyDapperField> dapperFields = Fields.FindAll(t => t.QueryOption.Equals(QueryOption.Include));
                if(dapperFields == null || dapperFields.Count <= 0) {
                    dapperFields = Fields.FindAll(t => t.QueryOption.Equals(QueryOption.Exclude) == false);
                }
                foreach(MyDapperField dapperField in dapperFields) {
                    if(string.IsNullOrEmpty(_temp) == false) {
                        _temp += ",";
                    }
                    _temp += "[" + dapperField.Name + "]";
                }
                return _temp;
            }
        }
    }
}
