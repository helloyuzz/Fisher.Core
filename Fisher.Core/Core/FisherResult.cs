using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public partial class FisherResult<T>:FisherResult {
        public int PageSize { get; internal set; } = -1;
        public int PageIndex { get; internal set; } = -1;
        public int TotalRecord { get; internal set; } = -1;
        public List<T> Result { get; internal set; } = new List<T>();
        public int TotalPage {
            get;
            internal set;
        }        
    }
    public partial class FisherResult {
        public Result Success { get; internal set; }
        public Exception Exception { get; internal set; }
        public string CommondText { get; internal set; }
        public int Pk_Id { get; internal set; }
        public string Pk_UUID {
            get;internal set;
        }
      
    }
    public enum Result {
        True = 0, False = 1, Exception = 2
    }
}
