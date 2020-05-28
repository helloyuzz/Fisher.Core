using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public class PaginationNeedOrderBy:Exception {
        public PaginationNeedOrderBy(string message) : base(message) {
        }
    }
}
