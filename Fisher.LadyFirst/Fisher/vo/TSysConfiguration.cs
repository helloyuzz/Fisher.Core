using System;
using System.Data;
using Fisher.Core;

namespace Fisher.LadyFirst {
    [Serializable]
    [FisherField(Name = "TSysConfiguration",Remarks = "")]
    public class TSysConfiguration {
        [FisherField(Name = "ConfigurationID",SqlDbType = SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ = 1,AllowDBNull = false,MaxLength = 4)]
        public virtual int? ConfigurationID {
            get;
            set;
        }
        [FisherField(Name = "ConfigurationKey",SqlDbType = SqlDbType.NVarChar,AllowDBNull = false,MaxLength = 100)]
        public virtual string ConfigurationKey {
            get;
            set;
        }
        [FisherField(Name = "Value",SqlDbType = SqlDbType.NText,MaxLength = 2147483646)]
        public virtual string Value {
            get;
            set;
        }
        [FisherField(Name = "Remark",SqlDbType = SqlDbType.NText,MaxLength = 2147483646)]
        public virtual string Remark {
            get;
            set;
        }
        [FisherField(Name = "IsDisabled",SqlDbType = SqlDbType.Bit,AllowDBNull = false,MaxLength = 1)]
        public virtual bool? IsDisabled {
            get;
            set;
        }
    }
}

