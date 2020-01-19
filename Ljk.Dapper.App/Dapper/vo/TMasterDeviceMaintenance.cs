using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterDeviceMaintenance",Remarks="")]
   public class TMasterDeviceMaintenance {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? DeviceID {
          get;
          set;
      }
      [LjkDapperField(Name="MaintenanceNum",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string MaintenanceNum {
          get;
          set;
      }
      [LjkDapperField(Name="MaintenanceDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? MaintenanceDate {
          get;
          set;
      }
      [LjkDapperField(Name="ServicePerson",SqlDbType=SqlDbType.NVarChar,MaxLength=100,Remarks="科室ID")]
      public virtual string ServicePerson {
          get;
          set;
      }
      [LjkDapperField(Name="ServicePhone",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ServicePhone {
          get;
          set;
      }
      [LjkDapperField(Name="MaintenanceMemo",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string MaintenanceMemo {
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
      [LjkDapperField(Name="DetailID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? DetailID {
          get;
          set;
      }
   }
}