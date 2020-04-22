using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryOneOffMaterialBatchInfos",Remarks="")]
   public class TInventoryOneOffMaterialBatchInfos {
      [LjkDapperField(Name="BatchInfoID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? BatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string BatchNumber {
          get;
          set;
      }
      [LjkDapperField(Name="ProductRegistrationNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductRegistrationNumber {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ManufacturerID {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? SterilizeTime {
          get;
          set;
      }
      [LjkDapperField(Name="Validity",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? Validity {
          get;
          set;
      }
      [LjkDapperField(Name="ProductionBatchNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductionBatchNumber {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeBatchNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SterilizeBatchNumber {
          get;
          set;
      }
      [LjkDapperField(Name="OneOffMaterialsInTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? OneOffMaterialsInTime {
          get;
          set;
      }
      [LjkDapperField(Name="IsNetworking",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsNetworking {
          get;
          set;
      }
      [LjkDapperField(Name="ProducedDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ProducedDate {
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