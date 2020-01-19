using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CSSD.Web.API.Dapper.vo
{
    public class SQLField
    {

        public SQLField(string fieldName,SqlDbType sqlDbType) {
            this.Name = fieldName;
            this.DbType = sqlDbType;
        }

        public SQLField(string fieldName,SqlDbType sqlDbType,bool isPrimaryKey) {
            this.Name = fieldName;
            this.DbType = sqlDbType;
            this.PrimaryKey = isPrimaryKey;
        }

        public virtual string Name {
            get;
            set;
        }
        public virtual SqlDbType DbType {
            get;
            set;
        }
        public virtual bool PrimaryKey {
            get;
            set;
        }
        public string Remarks {
            get;
            set;
        }
        public bool AllowDBNull {
            get;
            set;
        }
        public int MaxLength {
            get;
            set;
        }
    }
}
