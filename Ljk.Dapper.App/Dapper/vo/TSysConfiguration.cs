using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TSysConfiguration",Remarks="")]
   public class TSysConfiguration {
      [LjkDapperField(Name="ConfigurationID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ConfigurationID {
          get;
          set;
      }
      [LjkDapperField(Name="ConfigurationKey",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100,Remarks="FlowID")]
      public virtual string ConfigurationKey {
          get;
          set;
      }
      [LjkDapperField(Name="Value",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string Value {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string Remark {
          get;
          set;
      }
      [LjkDapperField(Name="IsDisabled",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1,Remarks="科室ID")]
      public virtual bool? IsDisabled {
          get;
          set;
      }
      [LjkDapperField(Name="int_field",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? int_field {
          get;
          set;
      }
      [LjkDapperField(Name="date_field",SqlDbType=SqlDbType.Date,MaxLength=20)]
      public virtual DateTime? date_field {
          get;
          set;
      }
      [LjkDapperField(Name="datetime_field",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? datetime_field {
          get;
          set;
      }
      [LjkDapperField(Name="float_field",SqlDbType=SqlDbType.Float,MaxLength=8)]
      public virtual double? float_field {
          get;
          set;
      }
      [LjkDapperField(Name="real_field",SqlDbType=SqlDbType.Real,MaxLength=4)]
      public virtual float? real_field {
          get;
          set;
      }
      [LjkDapperField(Name="char_field",SqlDbType=SqlDbType.Char,MaxLength=10)]
      public virtual string char_field {
          get;
          set;
      }
   }
}