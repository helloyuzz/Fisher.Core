using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterPatientOperation",Remarks="")]
   public class TMasterPatientOperation {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="PatientID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PatientID {
          get;
          set;
      }
      [LjkDapperField(Name="InternalMedicalRecordCode",SqlDbType=SqlDbType.NVarChar,MaxLength=72)]
      public virtual string InternalMedicalRecordCode {
          get;
          set;
      }
      [LjkDapperField(Name="OperationRoom",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OperationRoom {
          get;
          set;
      }
      [LjkDapperField(Name="OperationDepartment",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OperationDepartment {
          get;
          set;
      }
      [LjkDapperField(Name="OperationDate",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OperationDate {
          get;
          set;
      }
      [LjkDapperField(Name="OperationOrderCode",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OperationOrderCode {
          get;
          set;
      }
      [LjkDapperField(Name="OperationDoctor",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OperationDoctor {
          get;
          set;
      }
      [LjkDapperField(Name="OperationName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OperationName {
          get;
          set;
      }
      [LjkDapperField(Name="HandWashingNurse1",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string HandWashingNurse1 {
          get;
          set;
      }
      [LjkDapperField(Name="HandWashingNurse2",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string HandWashingNurse2 {
          get;
          set;
      }
      [LjkDapperField(Name="ItinerateNurse1",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string ItinerateNurse1 {
          get;
          set;
      }
      [LjkDapperField(Name="ItinerateNurse2",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string ItinerateNurse2 {
          get;
          set;
      }
      [LjkDapperField(Name="OperationStatus",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OperationStatus {
          get;
          set;
      }
      [LjkDapperField(Name="OperationBegin",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OperationBegin {
          get;
          set;
      }
      [LjkDapperField(Name="OperationEnd",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OperationEnd {
          get;
          set;
      }
      [LjkDapperField(Name="InRoomTime",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string InRoomTime {
          get;
          set;
      }
      [LjkDapperField(Name="OutRoomTime",SqlDbType=SqlDbType.NVarChar,MaxLength=40)]
      public virtual string OutRoomTime {
          get;
          set;
      }
      [LjkDapperField(Name="OperationFlag",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OperationFlag {
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