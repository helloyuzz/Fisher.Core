using System;
using Fisherman.Core;
using System.Data;

namespace App.DbLibrary {
   [Serializable]
   [FisherField(Name="TFlowApply",Remarks="")]
   public class TFlowApply {
      [FisherField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [FisherField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [FisherField(Name="ApplyDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ApplyDate {
          get;
          set;
      }
      [FisherField(Name="PatientID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PatientID {
          get;
          set;
      }
      [FisherField(Name="RegisterUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? RegisterUserID {
          get;
          set;
      }
      [FisherField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [FisherField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [FisherField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CreatedBy {
          get;
          set;
      }
      [FisherField(Name="UpdatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UpdatedBy {
          get;
          set;
      }
      [FisherField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
      [FisherField(Name="RegisterOrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? RegisterOrgID {
          get;
          set;
      }
      [FisherField(Name="OpenPackageUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OpenPackageUserID {
          get;
          set;
      }
   }
}