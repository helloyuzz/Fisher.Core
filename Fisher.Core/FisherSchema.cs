using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Fisher.Core {
    public class FisherSchema {
        public string SchemaName { get; set; }
        public List<MethodInfo> MethodInfos { get; set; }
        public List<FisherField> Fields { get; set; } = new List<FisherField>();
        public string SelectSQLFields {
            get {
                string _temp = "";
                List<FisherField> dapperFields = Fields.FindAll(t => t.QueryOption.Equals(QueryOption.Include));
                if(dapperFields == null || dapperFields.Count <= 0) {
                    dapperFields = Fields.FindAll(t => t.QueryOption.Equals(QueryOption.Exclude) == false);
                }
                foreach(FisherField dapperField in dapperFields) {
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
