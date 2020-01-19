using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TTraceClean",Remarks="")]
   public class TTraceClean {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="CleanUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? CleanUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ProcessID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProcessID {
          get;
          set;
      }
      [LjkDapperField(Name="CleanContainerID",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="科室ID")]
      public virtual int? CleanContainerID {
          get;
          set;
      }
      [LjkDapperField(Name="CleanContianerState",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? CleanContianerState {
          get;
          set;
      }
      [LjkDapperField(Name="ReviewState",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReviewState {
          get;
          set;
      }
      [LjkDapperField(Name="ReviewUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReviewUserID {
          get;
          set;
      }
      [LjkDapperField(Name="UnqualifiedID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? UnqualifiedID {
          get;
          set;
      }
      [LjkDapperField(Name="ReviewRemark",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string ReviewRemark {
          get;
          set;
      }
      [LjkDapperField(Name="ActionTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ActionTime {
          get;
          set;
      }
      [LjkDapperField(Name="ActionBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ActionBy {
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