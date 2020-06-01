using System;
using System.Data;
using Fisherman.Core;

namespace Fisherman.LadyFirst {
    [Serializable]
    [FisherField(Name = "TSysConfiguration",Remarks = "ConfigurationKeyaaa")]
    public class TSysConfiguration {
        [FisherField(Name = "ConfigurationID",SqlDbType = SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ = 1,CanotDBNull = false,MaxLength = 10,Remarks = "序号")]
        public virtual int? ConfigurationID {
            get;
            set;
        }
        [FisherField(Name = "ConfigurationKey",SqlDbType = SqlDbType.NVarChar,CanotDBNull = false,MaxLength = 50,Remarks = "ConfigurationKey")]
        public virtual string ConfigurationKey {
            get;
            set;
        }
        [FisherField(Name = "Value",SqlDbType = SqlDbType.NVarChar,CanotDBNull = false)]
        public virtual string Value {
            get;
            set;
        }
        [FisherField(Name = "Remark",SqlDbType = SqlDbType.NVarChar,CanotDBNull = false)]
        public virtual string Remark {
            get;
            set;
        }
        [FisherField(Name = "IsDisabled",SqlDbType = SqlDbType.Bit,CanotDBNull = false,MaxLength = 1,Remarks = "科室ID")]
        public virtual bool? IsDisabled {
            get;
            set;
        }
        [FisherField(Name = "int_field",SqlDbType = SqlDbType.Int,CanotDBNull = false,MaxLength = 10)]
        public virtual int? int_field {
            get;
            set;
        }
        [FisherField(Name = "date_field",SqlDbType = SqlDbType.Date,CanotDBNull = false,MaxLength = 10)]
        public virtual DateTime? date_field {
            get;
            set;
        }
        [FisherField(Name = "datetime_field",SqlDbType = SqlDbType.DateTime,CanotDBNull = false,MaxLength = 23)]
        public virtual DateTime? datetime_field {
            get;
            set;
        }
        [FisherField(Name = "float_field",SqlDbType = SqlDbType.Float,CanotDBNull = false,MaxLength = 53)]
        public virtual double? float_field {
            get;
            set;
        }
        [FisherField(Name = "real_field",SqlDbType = SqlDbType.Real,CanotDBNull = false,MaxLength = 24)]
        public virtual float? real_field {
            get;
            set;
        }
        [FisherField(Name = "char_field",SqlDbType = SqlDbType.Char,CanotDBNull = false,MaxLength = 10)]
        public virtual string char_field {
            get;
            set;
        }
    }
}