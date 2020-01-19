using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterPriority",Remarks="")]
   public class TMasterPriority {
      [LjkDapperField(Name="PriorityID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? PriorityID {
          get;
          set;
      }
      [LjkDapperField(Name="PriorityName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100,Remarks="FlowID")]
      public virtual string PriorityName {
          get;
          set;
      }
      [LjkDapperField(Name="PriorityColor",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string PriorityColor {
          get;
          set;
      }
      [LjkDapperField(Name="Priority",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Priority {
          get;
          set;
      }
      [LjkDapperField(Name="LimitedMinutes",SqlDbType=SqlDbType.Int,MaxLength=4,Remarks="科室ID")]
      public virtual int? LimitedMinutes {
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
      [LjkDapperField(Name="NameWithLabel",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string NameWithLabel {
          get;
          set;
      }
   }
}