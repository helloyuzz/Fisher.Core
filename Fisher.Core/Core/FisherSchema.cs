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
                List<FisherField> _fisherFields = Fields.FindAll(t => t.QueryOption.Equals(QueryOption.Include));
                if(_fisherFields == null || _fisherFields.Count <= 0) {
                    _fisherFields = Fields.FindAll(t => t.QueryOption.Equals(QueryOption.Exclude) == false);
                }
                foreach(FisherField fisherField in _fisherFields) {
                    if(string.IsNullOrEmpty(_temp) == false) {
                        _temp += ",";
                    }
                    _temp += "[" + fisherField.Name + "]";
                }
                return _temp;
            }
        }
    }
}
