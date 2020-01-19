using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterUser",Remarks="")]
   public class TMasterUser {
      [LjkDapperField(Name="UserID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? UserID {
          get;
          set;
      }
      [LjkDapperField(Name="UserCode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100,Remarks="FlowID")]
      public virtual string UserCode {
          get;
          set;
      }
      [LjkDapperField(Name="UserPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UserPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="UserFullName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UserFullName {
          get;
          set;
      }
      [LjkDapperField(Name="Password",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=400,Remarks="科室ID")]
      public virtual string Password {
          get;
          set;
      }
      [LjkDapperField(Name="UserBarcode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=400)]
      public virtual string UserBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="IsSterilizeUser",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IsSterilizeUser {
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