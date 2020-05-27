using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisher.Woman {
    public class MySQLField {
        public virtual string FieldName {
            get;
            set;
        }
        public virtual string Type {
            get;
            set;
        }
        public virtual string Key {
            get;
            set;
        }
        public virtual string Comment {
            get;
            set;
        }
        public virtual bool Checked { get; set; }
    }
}
