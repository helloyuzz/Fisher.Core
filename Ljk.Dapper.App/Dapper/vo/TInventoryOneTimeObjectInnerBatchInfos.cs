using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryOneTimeObjectInnerBatchInfos",Remarks="")]
   public class TInventoryOneTimeObjectInnerBatchInfos {
      [LjkDapperField(Name="InnerBatchInfoID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? InnerBatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchInfoID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? BatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="ProducedDate",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ProducedDate {
          get;
          set;
      }
      [LjkDapperField(Name="ExpiredTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ExpiredTime {
          get;
          set;
      }
      [LjkDapperField(Name="UnitPrice",SqlDbType=SqlDbType.Float,AllowDBNull =false,MaxLength=8,Remarks="科室ID")]
      public virtual double? UnitPrice {
          get;
          set;
      }
      [LjkDapperField(Name="LocationID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? LocationID {
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
      [LjkDapperField(Name="RegistNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string RegistNumber {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerName",SqlDbType=SqlDbType.NVarChar,MaxLength=200)]
      public virtual string ManufacturerName {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerAddress",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string ManufacturerAddress {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeDateTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? SterilizeDateTime {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SterilizeNumber {
          get;
          set;
      }
   }
}