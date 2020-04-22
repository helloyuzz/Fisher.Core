using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryOneTimeObjectInWarehouse",Remarks="")]
   public class TInventoryOneTimeObjectInWarehouse {
      [LjkDapperField(Name="InWarehouseID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? InWarehouseID {
          get;
          set;
      }
      [LjkDapperField(Name="InnerBatchInfoID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? InnerBatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="InWarehouseUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? InWarehouseUserID {
          get;
          set;
      }
      [LjkDapperField(Name="InWarehouseQuantity",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? InWarehouseQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="InWarehouseTime",SqlDbType=SqlDbType.DateTime,AllowDBNull =false,MaxLength=16)]
      public virtual DateTime? InWarehouseTime {
          get;
          set;
      }
      [LjkDapperField(Name="InWarehouseBatchCode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string InWarehouseBatchCode {
          get;
          set;
      }
      [LjkDapperField(Name="IsLock",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsLock {
          get;
          set;
      }
      [LjkDapperField(Name="PreInWarehouseID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? PreInWarehouseID {
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