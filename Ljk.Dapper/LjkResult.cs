using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljk.Dapper {
    public partial class LjkResult<T>:LjkResult {
        public int PageSize { get; set; } = -1;
        public int PageIndex { get; set; } = -1;
        public int TotalRecord { get; set; } = -1;
        public List<T> Result { get; set; } = new List<T>();
    }
    public partial class LjkResult {
        public Result ExecResult { get; set; }
        public Exception ExecException { get; set; }
        public string ShowSQLText { get; set; }
        public int RecentId { get;  set; }
        public string RecentUUID { get; set; }
    }
    public enum Result {
        OK, Falied, Exception
    }
}
