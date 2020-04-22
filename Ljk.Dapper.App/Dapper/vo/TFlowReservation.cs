using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowReservation",Remarks="")]
   public class TFlowReservation {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="OrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OrgID {
          get;
          set;
      }
      [LjkDapperField(Name="ApplyBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ApplyBy {
          get;
          set;
      }
      [LjkDapperField(Name="ApplyTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ApplyTime {
          get;
          set;
      }
      [LjkDapperField(Name="AuditTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? AuditTime {
          get;
          set;
      }
      [LjkDapperField(Name="AuditBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string AuditBy {
          get;
          set;
      }
      [LjkDapperField(Name="State",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? State {
          get;
          set;
      }
      [LjkDapperField(Name="CancelBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CancelBy {
          get;
          set;
      }
      [LjkDapperField(Name="CancelTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CancelTime {
          get;
          set;
      }
      [LjkDapperField(Name="CancelledBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CancelledBy {
          get;
          set;
      }
      [LjkDapperField(Name="CancelledTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CancelledTime {
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
      [LjkDapperField(Name="IsReceiptPrinted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsReceiptPrinted {
          get;
          set;
      }
      [LjkDapperField(Name="ReservationBatch",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ReservationBatch {
          get;
          set;
      }
      [LjkDapperField(Name="ReferenceCode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ReferenceCode {
          get;
          set;
      }
      [LjkDapperField(Name="Priority",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Priority {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string Remark {
          get;
          set;
      }
   }
}