using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public class TipMessage {
        private string _tipMessage;
        int _paraCount = -1;
        

        public TipMessage(string tipMessage,int paraCount=-1) {
            this._tipMessage = tipMessage;
            _paraCount = paraCount;
        }

        public string Message {
            get {
                return AddParams();
            }
        }

        internal string AddParams(params string[] param) {
            string _temp = _tipMessage;
            for(int n = 0;n < _paraCount;n++) {
                _temp = _temp.Replace("{" + n + "}",param[n]);
            }
            return _temp;
        }
    }
}
