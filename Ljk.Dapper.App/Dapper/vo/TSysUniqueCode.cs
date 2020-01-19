using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TSysUniqueCode",Remarks="")]
   public class TSysUniqueCode {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="Upper",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="FlowID")]
      public virtual int? Upper {
          get;
          set;
      }
      [LjkDapperField(Name="UniqueCode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=68)]
      public virtual string UniqueCode {
          get;
          set;
      }
   }
}