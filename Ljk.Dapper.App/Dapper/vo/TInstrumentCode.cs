using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TInstrumentCode",Remarks="")]
   public class TInstrumentCode {
      [LjkDapperField(Name="InstrumentCodeID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? InstrumentCodeID {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? InstrumentID {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentCodeName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string InstrumentCodeName {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentCodePinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string InstrumentCodePinYin {
          get;
          set;
      }
      [LjkDapperField(Name="Price",SqlDbType=SqlDbType.Decimal,MaxLength=15)]
      public virtual Decimal? Price {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentCodeType",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string InstrumentCodeType {
          get;
          set;
      }
      [LjkDapperField(Name="InstrumentCodeBrand",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string InstrumentCodeBrand {
          get;
          set;
      }
      [LjkDapperField(Name="MinUnit",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string MinUnit {
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