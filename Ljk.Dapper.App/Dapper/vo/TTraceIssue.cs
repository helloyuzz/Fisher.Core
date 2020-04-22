using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TTraceIssue",Remarks="")]
   public class TTraceIssue {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="IssueUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IssueUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ReceiveUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReceiveUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ActionTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ActionTime {
          get;
          set;
      }
      [LjkDapperField(Name="ActionBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ActionBy {
          get;
          set;
      }
      [LjkDapperField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
   }
}