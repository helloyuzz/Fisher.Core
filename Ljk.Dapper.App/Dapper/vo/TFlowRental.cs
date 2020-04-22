using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowRental",Remarks="")]
   public class TFlowRental {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="RentQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RentQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="ReturnQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReturnQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="ComputedQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ComputedQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="Rent1stUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Rent1stUserID {
          get;
          set;
      }
      [LjkDapperField(Name="Rent2ndUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Rent2ndUserID {
          get;
          set;
      }
      [LjkDapperField(Name="Rent2ndUserName",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string Rent2ndUserName {
          get;
          set;
      }
      [LjkDapperField(Name="Rent2ndOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Rent2ndOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="ReturnUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ReturnUserID {
          get;
          set;
      }
      [LjkDapperField(Name="RentTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? RentTime {
          get;
          set;
      }
      [LjkDapperField(Name="ReturnTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ReturnTime {
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
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="Rent1stOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? Rent1stOrgID {
          get;
          set;
      }
   }
}