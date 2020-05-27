using System;
using Fisher.Core;
using System.Data;

namespace Fisher.Core.DbLibrary {
   [Serializable]
   [FisherField(Name="TFlowContainerInFlow",Remarks="")]
   public class TFlowContainerInFlow {
      [FisherField(Name="ContainerFlowID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ContainerFlowID {
          get;
          set;
      }
      [FisherField(Name="ContainerID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ContainerID {
          get;
          set;
      }
      [FisherField(Name="ContainerFlowState",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ContainerFlowState {
          get;
          set;
      }
      [FisherField(Name="PreContainerFlowID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PreContainerFlowID {
          get;
          set;
      }
      [FisherField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [FisherField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [FisherField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CreatedBy {
          get;
          set;
      }
      [FisherField(Name="UpdatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UpdatedBy {
          get;
          set;
      }
      [FisherField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
      [FisherField(Name="CleanType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? CleanType {
          get;
          set;
      }
   }
}