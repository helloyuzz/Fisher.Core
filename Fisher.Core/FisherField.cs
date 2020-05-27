using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Fisher.Core {
    public class FisherField:Attribute {
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
        public SqlDbType SqlDbType { get; set; }
        public bool AllowDBNull { get; set; } = true;
        public int MaxLength { get; set; }
        public string Remarks { get; set; }
        /// <summary>
        /// 默认不包括，需显示指定为False（表示才能加入查询结果集）
        /// </summary>
        public QueryOption QueryOption { get; set; } = QueryOption.Default;
        public int KEY_SEQ { get; set; }
    }
    public enum QueryOption {
        /// <summary>
        /// 默认
        /// </summary>
        Default,
        /// <summary>
        /// 包括
        /// </summary>
        Include,
        /// <summary>
        /// 不包括
        /// </summary>
        Exclude
    }
}
