using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowSterileWarehouse",Remarks="")]
   public class TFlowSterileWarehouse {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="LocationID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? LocationID {
          get;
          set;
      }
      [LjkDapperField(Name="OrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OrgID {
          get;
          set;
      }
      [LjkDapperField(Name="IsOntBound",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsOntBound {
          get;
          set;
      }
      [LjkDapperField(Name="OutBoundType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OutBoundType {
          get;
          set;
      }
      [LjkDapperField(Name="ActionUserID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ActionUserID {
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