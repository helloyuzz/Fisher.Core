using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowRecycleAbnormal",Remarks="")]
   public class TFlowRecycleAbnormal {
      [LjkDapperField(Name="RecycleAbnormalID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? RecycleAbnormalID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="Quantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Quantity {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=1000)]
      public virtual string Remark {
          get;
          set;
      }
      [LjkDapperField(Name="AbnormalReason",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? AbnormalReason {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? InstrumentID {
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
      [LjkDapperField(Name="AbnormalType",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? AbnormalType {
          get;
          set;
      }
   }
}