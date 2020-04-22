using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterProduct",Remarks="")]
   public class TMasterProduct {
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string ProductName {
          get;
          set;
      }
      [LjkDapperField(Name="ProductPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="TypeID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? TypeID {
          get;
          set;
      }
      [LjkDapperField(Name="PackageTypeID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PackageTypeID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductModel",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductModel {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeTypeID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SterilizeTypeID {
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