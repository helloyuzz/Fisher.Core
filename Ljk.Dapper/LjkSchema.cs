using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ljk.Dapper {
    public class LjkSchema {
        public string SchemaName { get; set; }
        public List<MethodInfo> MethodInfos { get; set; }
        public List<LjkDapperField> Fields { get; set; } = new List<LjkDapperField>();
        public string SelectSQLFieldString {
            get {
                string _temp = "";
                List<LjkDapperField> dapperFields = Fields.FindAll(t => t.Include.Equals(Include.True));
                if(dapperFields == null || dapperFields.Count <=0) {
                    dapperFields = Fields.FindAll(t => t.Include.Equals(Include.False) == false);
                }
                foreach(LjkDapperField dapperField in dapperFields) {               
                    if(string.IsNullOrEmpty(_temp) == false) {
                        _temp += ",";
                    }
                    _temp += "[" +dapperField.Name+"]";
                }
                return _temp;
            }
        }
    }
}
