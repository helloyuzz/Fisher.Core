using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterProductPrice",Remarks="")]
   public class TMasterProductPrice {
      [LjkDapperField(Name="ProductPriceID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ProductPriceID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductPrice",SqlDbType=SqlDbType.Float,MaxLength=8)]
      public virtual double? ProductPrice {
          get;
          set;
      }
      [LjkDapperField(Name="CostPrice",SqlDbType=SqlDbType.Float,MaxLength=8)]
      public virtual double? CostPrice {
          get;
          set;
      }
      [LjkDapperField(Name="ValidFrom",SqlDbType=SqlDbType.DateTime,MaxLength=16,Remarks="科室ID")]
      public virtual DateTime? ValidFrom {
          get;
          set;
      }
      [LjkDapperField(Name="ValidTo",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ValidTo {
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