using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowState2",Remarks="")]
   public class TFlowState2 {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=100,Remarks="FlowID")]
      public virtual string FlowBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="IsRecalled",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsRecalled {
          get;
          set;
      }
      [LjkDapperField(Name="IsAbnormal",SqlDbType=SqlDbType.Bit,MaxLength=1,Remarks="科室ID")]
      public virtual bool? IsAbnormal {
          get;
          set;
      }
      [LjkDapperField(Name="IsRecycle",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsRecycle {
          get;
          set;
      }
      [LjkDapperField(Name="IsApply",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsApply {
          get;
          set;
      }
      [LjkDapperField(Name="IsExpired",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsExpired {
          get;
          set;
      }
      [LjkDapperField(Name="IsRental",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsRental {
          get;
          set;
      }
      [LjkDapperField(Name="TaskID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? TaskID {
          get;
          set;
      }
      [LjkDapperField(Name="TaskType",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? TaskType {
          get;
          set;
      }
      [LjkDapperField(Name="TaskState",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? TaskState {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
   }
}