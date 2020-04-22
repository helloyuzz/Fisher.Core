using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowUploadRecycleData",Remarks="")]
   public class TFlowUploadRecycleData {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? BatchID {
          get;
          set;
      }
      [LjkDapperField(Name="RecycleID",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string RecycleID {
          get;
          set;
      }
      [LjkDapperField(Name="RecyclePrimaryKeyID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RecyclePrimaryKeyID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="PriorityID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PriorityID {
          get;
          set;
      }
      [LjkDapperField(Name="NewFlowID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? NewFlowID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="SendPackageOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SendPackageOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="RentalID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RentalID {
          get;
          set;
      }
      [LjkDapperField(Name="RentOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RentOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="RecycleUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RecycleUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ReceiveUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReceiveUserID {
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
      [LjkDapperField(Name="IsUpload",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? IsUpload {
          get;
          set;
      }
   }
}