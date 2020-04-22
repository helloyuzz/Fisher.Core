using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TSysTaskConfiguration",Remarks="")]
   public class TSysTaskConfiguration {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="TaskIndex",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? TaskIndex {
          get;
          set;
      }
      [LjkDapperField(Name="TaskType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? TaskType {
          get;
          set;
      }
      [LjkDapperField(Name="IsRequired",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsRequired {
          get;
          set;
      }
      [LjkDapperField(Name="OrgType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OrgType {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string Remark {
          get;
          set;
      }
   }
}