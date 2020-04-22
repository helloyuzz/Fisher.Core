using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterProcess",Remarks="")]
   public class TMasterProcess {
      [LjkDapperField(Name="ProcessID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProcessID {
          get;
          set;
      }
      [LjkDapperField(Name="ProcessName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string ProcessName {
          get;
          set;
      }
      [LjkDapperField(Name="ProcessPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProcessPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="ProcessBarcode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string ProcessBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="ProcessType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProcessType {
          get;
          set;
      }
      [LjkDapperField(Name="ReportPrintPath",SqlDbType=SqlDbType.NVarChar,MaxLength=200)]
      public virtual string ReportPrintPath {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? DeviceID {
          get;
          set;
      }
      [LjkDapperField(Name="IsManualProcess",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? IsManualProcess {
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