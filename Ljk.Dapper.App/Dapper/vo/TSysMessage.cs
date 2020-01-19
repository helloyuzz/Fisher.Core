using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TSysMessage",Remarks="")]
   public class TSysMessage {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="MessageID",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=200,Remarks="FlowID")]
      public virtual string MessageID {
          get;
          set;
      }
      [LjkDapperField(Name="UserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? UserID {
          get;
          set;
      }
      [LjkDapperField(Name="Content",SqlDbType=SqlDbType.NText,AllowDBNull =false,MaxLength=2147483646)]
      public virtual string Content {
          get;
          set;
      }
      [LjkDapperField(Name="IsRead",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1,Remarks="科室ID")]
      public virtual bool? IsRead {
          get;
          set;
      }
      [LjkDapperField(Name="MessegeType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? MessegeType {
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