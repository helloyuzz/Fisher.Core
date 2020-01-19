using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterProductSimple",Remarks="")]
   public class TMasterProductSimple {
      [LjkDapperField(Name="ProductSimpleID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ProductSimpleID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductSimpleName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100,Remarks="FlowID")]
      public virtual string ProductSimpleName {
          get;
          set;
      }
      [LjkDapperField(Name="ProductSimplePinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ProductSimplePinYin {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16,Remarks="科室ID")]
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