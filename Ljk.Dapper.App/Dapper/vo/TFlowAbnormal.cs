using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowAbnormal",Remarks="")]
   public class TFlowAbnormal {
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
      [LjkDapperField(Name="AbnormalID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? AbnormalID {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string Remark {
          get;
          set;
      }
      [LjkDapperField(Name="BatchGUID",SqlDbType=SqlDbType.NVarChar,MaxLength=400)]
      public virtual string BatchGUID {
          get;
          set;
      }
      [LjkDapperField(Name="RegisterUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RegisterUserID {
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
      [LjkDapperField(Name="IsContinuable",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsContinuable {
          get;
          set;
      }
   }
}