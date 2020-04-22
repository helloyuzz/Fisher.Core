using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterAccess",Remarks="")]
   public class TMasterAccess {
      [LjkDapperField(Name="AccessID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? AccessID {
          get;
          set;
      }
      [LjkDapperField(Name="RootAccessID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RootAccessID {
          get;
          set;
      }
      [LjkDapperField(Name="AccessName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string AccessName {
          get;
          set;
      }
      [LjkDapperField(Name="AccessIconName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string AccessIconName {
          get;
          set;
      }
      [LjkDapperField(Name="AccessUri",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string AccessUri {
          get;
          set;
      }
      [LjkDapperField(Name="AccessType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? AccessType {
          get;
          set;
      }
      [LjkDapperField(Name="SystemEdition",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? SystemEdition {
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