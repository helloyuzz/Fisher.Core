using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Ljk.Dapper {
    public class LjkDapperField:Attribute {
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
        public SqlDbType SqlDbType { get; set; }
        public bool AllowDBNull { get; set; } = true;
        public int MaxLength { get; set; }
        public string Remarks { get; set; }
        /// <summary>
        /// 默认不包括，需显示指定为False（表示才能加入查询结果集）
        /// </summary>
        public Include Include { get; set; } = Include.Default;
        public int KEY_SEQ { get; set; }
    }
    public enum Include {
        Default,True,False
    }
}
