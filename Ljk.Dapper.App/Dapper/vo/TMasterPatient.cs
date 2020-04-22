using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterPatient",Remarks="")]
   public class TMasterPatient {
      [LjkDapperField(Name="PatientID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? PatientID {
          get;
          set;
      }
      [LjkDapperField(Name="PatientName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string PatientName {
          get;
          set;
      }
      [LjkDapperField(Name="PatientCode",SqlDbType=SqlDbType.NVarChar,MaxLength=72)]
      public virtual string PatientCode {
          get;
          set;
      }
      [LjkDapperField(Name="MedicalRecordCode",SqlDbType=SqlDbType.NVarChar,MaxLength=72)]
      public virtual string MedicalRecordCode {
          get;
          set;
      }
      [LjkDapperField(Name="PatientSex",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? PatientSex {
          get;
          set;
      }
      [LjkDapperField(Name="PatientBirthday",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string PatientBirthday {
          get;
          set;
      }
      [LjkDapperField(Name="PatientAge",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PatientAge {
          get;
          set;
      }
      [LjkDapperField(Name="PatientIDCard",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string PatientIDCard {
          get;
          set;
      }
      [LjkDapperField(Name="SocialSecurityCard",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SocialSecurityCard {
          get;
          set;
      }
      [LjkDapperField(Name="PatientAddress",SqlDbType=SqlDbType.NVarChar,MaxLength=1000)]
      public virtual string PatientAddress {
          get;
          set;
      }
      [LjkDapperField(Name="PatientPhone",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string PatientPhone {
          get;
          set;
      }
      [LjkDapperField(Name="HighRiskInfectivity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? HighRiskInfectivity {
          get;
          set;
      }
      [LjkDapperField(Name="BaseFlag",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string BaseFlag {
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
      [LjkDapperField(Name="RegisterCode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string RegisterCode {
          get;
          set;
      }
      [LjkDapperField(Name="InPatientCode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string InPatientCode {
          get;
          set;
      }
      [LjkDapperField(Name="InternalMedicalRecordCode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string InternalMedicalRecordCode {
          get;
          set;
      }
   }
}