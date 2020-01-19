using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterTag",Remarks="")]
   public class TMasterTag {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="TagBinary",SqlDbType=SqlDbType.Int,MaxLength=2147483647,Remarks="FlowID")]
      public virtual int? TagBinary {
          get;
          set;
      }
      [LjkDapperField(Name="TagName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string TagName {
          get;
          set;
      }
      [LjkDapperField(Name="TagPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string TagPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=1000,Remarks="科室ID")]
      public virtual string Remark {
          get;
          set;
      }
      [LjkDapperField(Name="IsCustom",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsCustom {
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