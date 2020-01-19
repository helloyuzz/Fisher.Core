using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterOneOffMaterialsClassify",Remarks="")]
   public class TMasterOneOffMaterialsClassify {
      [LjkDapperField(Name="ClassifyID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ClassifyID {
          get;
          set;
      }
      [LjkDapperField(Name="ClassifyName",SqlDbType=SqlDbType.NVarChar,MaxLength=100,Remarks="FlowID")]
      public virtual string ClassifyName {
          get;
          set;
      }
      [LjkDapperField(Name="ClassifyPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ClassifyPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="ClassifyDiscription",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ClassifyDiscription {
          get;
          set;
      }
      [LjkDapperField(Name="IsAddSterilize",SqlDbType=SqlDbType.Bit,MaxLength=1,Remarks="科室ID")]
      public virtual bool? IsAddSterilize {
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