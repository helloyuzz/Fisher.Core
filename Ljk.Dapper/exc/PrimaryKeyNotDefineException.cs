using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljk.Dapper.exc {
    public class PrimaryKeyNotDefineException:Exception {
        public PrimaryKeyNotDefineException(string message) : base(message) {
            message += "未定义主键。";
        }
    }
}
