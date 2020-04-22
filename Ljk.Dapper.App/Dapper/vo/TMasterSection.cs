using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterSection",Remarks="")]
   public class TMasterSection {
      [LjkDapperField(Name="SectionID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? SectionID {
          get;
          set;
      }
      [LjkDapperField(Name="OrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OrgID {
          get;
          set;
      }
      [LjkDapperField(Name="SectionName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string SectionName {
          get;
          set;
      }
      [LjkDapperField(Name="SectionPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string SectionPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="SectionBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string SectionBarcode {
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