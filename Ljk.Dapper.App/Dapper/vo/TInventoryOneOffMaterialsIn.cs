using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryOneOffMaterialsIn",Remarks="")]
   public class TInventoryOneOffMaterialsIn {
      [LjkDapperField(Name="OneOffMaterialsID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? OneOffMaterialsID {
          get;
          set;
      }
      [LjkDapperField(Name="InnerBatchInfoID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? InnerBatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="LocationID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? LocationID {
          get;
          set;
      }
      [LjkDapperField(Name="ApplyUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ApplyUserID {
          get;
          set;
      }
      [LjkDapperField(Name="UnitPrice",SqlDbType=SqlDbType.Decimal,MaxLength=20,Remarks="科室ID")]
      public virtual Decimal? UnitPrice {
          get;
          set;
      }
      [LjkDapperField(Name="Quantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Quantity {
          get;
          set;
      }
      [LjkDapperField(Name="SpecificationID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SpecificationID {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string Remark {
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