using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterDeviceInfo",Remarks="")]
   public class TMasterDeviceInfo {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DeviceID {
          get;
          set;
      }
      [LjkDapperField(Name="SupplierName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SupplierName {
          get;
          set;
      }
      [LjkDapperField(Name="ProducedDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ProducedDate {
          get;
          set;
      }
      [LjkDapperField(Name="MaintenanceCycle",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? MaintenanceCycle {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ManufacturerName {
          get;
          set;
      }
      [LjkDapperField(Name="UsedDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UsedDate {
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
      [LjkDapperField(Name="IsMustBeMaintenance",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsMustBeMaintenance {
          get;
          set;
      }
   }
}