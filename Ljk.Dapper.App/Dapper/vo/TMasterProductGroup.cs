using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterProductGroup",Remarks="")]
   public class TMasterProductGroup {
      [LjkDapperField(Name="ProductGroupID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProductGroupID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductGroupName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductGroupName {
          get;
          set;
      }
      [LjkDapperField(Name="ProductGroupPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductGroupPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="ProductGroupDiscription",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string ProductGroupDiscription {
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