using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public class IllegalField:Exception {
        public IllegalField(string message) : base(message) {
        }
    }
}
