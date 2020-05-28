using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public class FieldNotAllowNull:Exception {
        public FieldNotAllowNull(string message) : base(message) {
        }
    }
}
