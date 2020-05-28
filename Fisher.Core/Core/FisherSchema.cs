using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Fisherman.Core {
    public class FisherSchema {
        public string SchemaName { get; set; }
        public List<MethodInfo> MethodInfos { get; set; }
        public List<FisherField> Fields { get; set; } = new List<FisherField>();
        /// <summary>
        /// 获取要查询的字段列表，并拼装为字符串的形式，默认标记为Include的字段
        /// </summary>
        public string GetIncludeSQLFields {
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
