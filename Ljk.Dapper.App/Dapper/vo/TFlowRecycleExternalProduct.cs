using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowRecycleExternalProduct",Remarks="")]
   public class TFlowRecycleExternalProduct {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="ApplyOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ApplyOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="PackageQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PackageQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentQuantity",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="科室ID")]
      public virtual int? InstrumentQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="ImplantQuatity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ImplantQuatity {
          get;
          set;
      }
      [LjkDapperField(Name="SubpackageQuantity",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? SubpackageQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="HaveImplants",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? HaveImplants {
          get;
          set;
      }
      [LjkDapperField(Name="IsSpare",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsSpare {
          get;
          set;
      }
      [LjkDapperField(Name="OuterPacking",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OuterPacking {
          get;
          set;
      }
      [LjkDapperField(Name="SendUserName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SendUserName {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizationMethod",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SterilizationMethod {
          get;
          set;
      }
      [LjkDapperField(Name="PatientID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PatientID {
          get;
          set;
      }
      [LjkDapperField(Name="ReceiveUserName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ReceiveUserName {
          get;
          set;
      }
      [LjkDapperField(Name="RegistrationTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? RegistrationTime {
          get;
          set;
      }
      [LjkDapperField(Name="CleanType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? CleanType {
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
      [LjkDapperField(Name="ProductGroupID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProductGroupID {
          get;
          set;
      }
      [LjkDapperField(Name="SubPackageGUID",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SubPackageGUID {
          get;
          set;
      }
      [LjkDapperField(Name="SendUnit",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SendUnit {
          get;
          set;
      }
      [LjkDapperField(Name="OperationDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? OperationDate {
          get;
          set;
      }
      [LjkDapperField(Name="OperationDoctor",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OperationDoctor {
          get;
          set;
      }
   }
}