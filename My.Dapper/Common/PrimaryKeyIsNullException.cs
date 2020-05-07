using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Dapper.Common {
    public class PrimaryKeyIsNullException:Exception {
        public PrimaryKeyIsNullException(string message) : base(message) {
            message += "未定义主键。";
        }
    }
}
