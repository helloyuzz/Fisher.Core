using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInventoryStock",Remarks="")]
   public class TInventoryStock {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="WarehouseID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? WarehouseID {
          get;
          set;
      }
      [LjkDapperField(Name="InventoryUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? InventoryUserID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchInfoID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? BatchInfoID {
          get;
          set;
      }
      [LjkDapperField(Name="Details",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string Details {
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