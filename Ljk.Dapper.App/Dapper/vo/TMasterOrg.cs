using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterOrg",Remarks="")]
   public class TMasterOrg {
      [LjkDapperField(Name="OrgID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? OrgID {
          get;
          set;
      }
      [LjkDapperField(Name="OrgName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100,Remarks="FlowID")]
      public virtual string OrgName {
          get;
          set;
      }
      [LjkDapperField(Name="OrgPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string OrgPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="OrgBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string OrgBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16,Remarks="科室ID")]
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
      [LjkDapperField(Name="OrgType",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? OrgType {
          get;
          set;
      }
   }
}