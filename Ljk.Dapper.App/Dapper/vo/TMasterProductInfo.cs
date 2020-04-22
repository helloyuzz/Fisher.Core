using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterProductInfo",Remarks="")]
   public class TMasterProductInfo {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="SupplierName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SupplierName {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ManufacturerName {
          get;
          set;
      }
      [LjkDapperField(Name="OrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? OrgID {
          get;
          set;
      }
      [LjkDapperField(Name="IsContainImplant",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IsContainImplant {
          get;
          set;
      }
      [LjkDapperField(Name="IsCommonPackage",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IsCommonPackage {
          get;
          set;
      }
      [LjkDapperField(Name="SafeInventoryQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SafeInventoryQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="IsHighLevelsSterilize",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IsHighLevelsSterilize {
          get;
          set;
      }
      [LjkDapperField(Name="ShapeTypeID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ShapeTypeID {
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
      [LjkDapperField(Name="IsUniquePackage",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsUniquePackage {
          get;
          set;
      }
      [LjkDapperField(Name="UniqueBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UniqueBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="IsDynamicPackage",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDynamicPackage {
          get;
          set;
      }
      [LjkDapperField(Name="CleanType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? CleanType {
          get;
          set;
      }
      [LjkDapperField(Name="CategoryBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CategoryBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="FlowRate",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowRate {
          get;
          set;
      }
   }
}