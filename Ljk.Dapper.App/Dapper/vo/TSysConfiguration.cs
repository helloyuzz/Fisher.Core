using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TSysConfiguration",Remarks="")]
   public class TSysConfiguration {
      [LjkDapperField(Name="ConfigurationID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ConfigurationID {
          get;
          set;
      }
      [LjkDapperField(Name="ConfigurationKey",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
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
      [LjkDapperField(Name="IsDisabled",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDisabled {
          get;
          set;
      }
   }
}