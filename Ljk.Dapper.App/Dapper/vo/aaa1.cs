using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="aaa1",Remarks="")]
   public class aaa1 {
      [LjkDapperField(Name="uuid",SqlDbType=SqlDbType.UniqueIdentifier,MaxLength=16,Remarks="序号")]
      public virtual string uuid {
          get;
          set;
      }
      [LjkDapperField(Name="code",SqlDbType=SqlDbType.NVarChar,MaxLength=100,Remarks="FlowID")]
      public virtual string code {
          get;
          set;
      }
   }
}