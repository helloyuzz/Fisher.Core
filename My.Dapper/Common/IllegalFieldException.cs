using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Dapper.Common {
    public class IllegalFieldException:Exception {
        public IllegalFieldException(string message) : base(message) {
        }
    }
}
