using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljk.Dapper.exc {
    public class FieldNotAllowDBNullException:Exception {
        public FieldNotAllowDBNullException(string message) : base(message) {
        }
    }
}
