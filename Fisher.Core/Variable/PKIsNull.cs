using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public class PKIsNull:Exception {
        public PKIsNull(string message) : base(message) {
        }
    }
}
