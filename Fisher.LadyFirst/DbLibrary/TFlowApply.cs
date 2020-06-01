using System;
using Fisherman.Core;
using System.Data;

namespace App.DbLibrary {
   [Serializable]
   [FisherField(Name="TFlowApply",Remarks="TFlowApply表定义")]
   public class TFlowApply {
      [FisherField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=10,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [FisherField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10,Remarks="ConfigurationKey")]
      public virtual int? FlowID {
          get;
          set;
      }
      [FisherField(Name="ApplyDate",SqlDbType=SqlDbType.DateTime,AllowDBNull =false,MaxLength=23)]
      public virtual DateTime? ApplyDate {
          get;
          set;
      }
      [FisherField(Name="PatientID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10)]
      public virtual int? PatientID {
          get;
          set;
      }
      [FisherField(Name="RegisterOrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10,Remarks="科室ID")]
      public virtual int? RegisterOrgID {
          get;
          set;
      }
      [FisherField(Name="RegisterUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10)]
      public virtual int? RegisterUserID {
          get;
          set;
      }
      [FisherField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,AllowDBNull =false,MaxLength=23)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [FisherField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,AllowDBNull =false,MaxLength=23)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [FisherField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=50)]
      public virtual string CreatedBy {
          get;
          set;
      }
      [FisherField(Name="UpdatedBy",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=50)]
      public virtual string UpdatedBy {
          get;
          set;
      }
      [FisherField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
      [FisherField(Name="OpenPackageUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10)]
      public virtual int? OpenPackageUserID {
          get;
          set;
      }
   }
}