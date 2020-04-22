using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterContainer",Remarks="")]
   public class TMasterContainer {
      [LjkDapperField(Name="ContainerID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ContainerID {
          get;
          set;
      }
      [LjkDapperField(Name="ContainerName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string ContainerName {
          get;
          set;
      }
      [LjkDapperField(Name="ContainerPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ContainerPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="ContainerTypeID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ContainerTypeID {
          get;
          set;
      }
      [LjkDapperField(Name="ContainerBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ContainerBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="ShapeTypeID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ShapeTypeID {
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