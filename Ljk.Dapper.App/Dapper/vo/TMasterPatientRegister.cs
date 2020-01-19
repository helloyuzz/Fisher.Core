using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterPatientRegister",Remarks="")]
   public class TMasterPatientRegister {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="PatientID",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="FlowID")]
      public virtual int? PatientID {
          get;
          set;
      }
      [LjkDapperField(Name="RegisterCode",SqlDbType=SqlDbType.NVarChar,MaxLength=72)]
      public virtual string RegisterCode {
          get;
          set;
      }
      [LjkDapperField(Name="OutPatientEmergency",SqlDbType=SqlDbType.NVarChar,MaxLength=20)]
      public virtual string OutPatientEmergency {
          get;
          set;
      }
      [LjkDapperField(Name="RegisterDateTime",SqlDbType=SqlDbType.NVarChar,MaxLength=40,Remarks="科室ID")]
      public virtual string RegisterDateTime {
          get;
          set;
      }
      [LjkDapperField(Name="RegisterDepartment",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string RegisterDepartment {
          get;
          set;
      }
      [LjkDapperField(Name="RegisterFlag",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string RegisterFlag {
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