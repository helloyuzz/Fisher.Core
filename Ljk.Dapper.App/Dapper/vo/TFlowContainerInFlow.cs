using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowContainerInFlow",Remarks="")]
   public class TFlowContainerInFlow {
      [LjkDapperField(Name="ContainerFlowID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ContainerFlowID {
          get;
          set;
      }
      [LjkDapperField(Name="ContainerID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="FlowID")]
      public virtual int? ContainerID {
          get;
          set;
      }
      [LjkDapperField(Name="ContainerFlowState",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ContainerFlowState {
          get;
          set;
      }
      [LjkDapperField(Name="PreContainerFlowID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PreContainerFlowID {
          get;
          set;
      }
      [LjkDapperField(Name="CleanType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4,Remarks="科室ID")]
      public virtual int? CleanType {
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