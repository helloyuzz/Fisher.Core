using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljk.Dapper.exc {
    public class IllegalFieldException:Exception {
        public IllegalFieldException(string message) : base(message) {
        }
    }
}
