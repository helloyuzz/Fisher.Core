using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowIssueManually",Remarks="")]
   public class TFlowIssueManually {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="Quantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Quantity {
          get;
          set;
      }
      [LjkDapperField(Name="IssueUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IssueUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ReceiveUserID",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="科室ID")]
      public virtual int? ReceiveUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ReceiveOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReceiveOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CreatedBy {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UpdatedBy {
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