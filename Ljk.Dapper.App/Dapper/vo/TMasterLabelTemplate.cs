using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterLabelTemplate",Remarks="")]
   public class TMasterLabelTemplate {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="TemplateType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? TemplateType {
          get;
          set;
      }
      [LjkDapperField(Name="Name",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string Name {
          get;
          set;
      }
      [LjkDapperField(Name="Width",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Width {
          get;
          set;
      }
      [LjkDapperField(Name="Height",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="科室ID")]
      public virtual int? Height {
          get;
          set;
      }
      [LjkDapperField(Name="DisPlayName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string DisPlayName {
          get;
          set;
      }
      [LjkDapperField(Name="Relation",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string Relation {
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