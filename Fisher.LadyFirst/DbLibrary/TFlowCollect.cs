using System;
using Fisher.Core;
using System.Data;

namespace Fisher.Core.DbLibrary {
   [Serializable]
   [FisherField(Name="TFlowCollect",Remarks="")]
   public class TFlowCollect {
      [FisherField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [FisherField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [FisherField(Name="IssueUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? IssueUserID {
          get;
          set;
      }
      [FisherField(Name="CollectUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? CollectUserID {
          get;
          set;
      }
      [FisherField(Name="IsReturn",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsReturn {
          get;
          set;
      }
      [FisherField(Name="SectionID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SectionID {
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
      [FisherField(Name="ReturnUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReturnUserID {
          get;
          set;
      }
   }
}