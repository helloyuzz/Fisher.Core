using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TTraceSterilize",Remarks="")]
   public class TTraceSterilize {
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
      [LjkDapperField(Name="SterilizeUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SterilizeUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ProcessID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProcessID {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? DeviceID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchNumber",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? BatchNumber {
          get;
          set;
      }
      [LjkDapperField(Name="ExpiredTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ExpiredTime {
          get;
          set;
      }
      [LjkDapperField(Name="BundleBarcode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string BundleBarcode {
          get;
          set;
      }
      [LjkDapperField(Name="ActionTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ActionTime {
          get;
          set;
      }
      [LjkDapperField(Name="ActionBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ActionBy {
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