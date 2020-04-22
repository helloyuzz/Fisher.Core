using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryOneOffMaterialInnerBatchInfos",Remarks="")]
   public class TInventoryOneOffMaterialInnerBatchInfos {
      [LjkDapperField(Name="InnerBatchInfoID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? InnerBatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchInfoID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? BatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="UnitPrice",SqlDbType=SqlDbType.Float,AllowDBNull =false,MaxLength=8)]
      public virtual double? UnitPrice {
          get;
          set;
      }
      [LjkDapperField(Name="InnerBatchNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=50)]
      public virtual string InnerBatchNumber {
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