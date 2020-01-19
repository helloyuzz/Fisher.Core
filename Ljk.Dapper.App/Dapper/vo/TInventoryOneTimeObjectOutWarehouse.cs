using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryOneTimeObjectOutWarehouse",Remarks="")]
   public class TInventoryOneTimeObjectOutWarehouse {
      [LjkDapperField(Name="OutWarehouseID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? OutWarehouseID {
          get;
          set;
      }
      [LjkDapperField(Name="InnerBatchInfoID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? InnerBatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="OutWarehouseQuantity",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OutWarehouseQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="ReceiveUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ReceiveUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ReceivingOrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="科室ID")]
      public virtual int? ReceivingOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="OutWarehouseTime",SqlDbType=SqlDbType.DateTime,AllowDBNull =false,MaxLength=16)]
      public virtual DateTime? OutWarehouseTime {
          get;
          set;
      }
      [LjkDapperField(Name="OutWarehouseBatchCode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string OutWarehouseBatchCode {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=1000)]
      public virtual string Remark {
          get;
          set;
      }
      [LjkDapperField(Name="IsLock",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsLock {
          get;
          set;
      }
      [LjkDapperField(Name="PreOutWarehouseID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? PreOutWarehouseID {
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