using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TinventorySpecification",Remarks="")]
   public class TinventorySpecification {
      [LjkDapperField(Name="SpecificationID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? SpecificationID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="MiniUnitQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? MiniUnitQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="MiniUnit",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string MiniUnit {
          get;
          set;
      }
      [LjkDapperField(Name="BigUnit",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string BigUnit {
          get;
          set;
      }
      [LjkDapperField(Name="Specification",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string Specification {
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