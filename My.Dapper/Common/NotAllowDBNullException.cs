using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Dapper.Common {
    public class NotAllowDBNullException:Exception {
        public NotAllowDBNullException(string message) : base(message) {
        }
    }
}
