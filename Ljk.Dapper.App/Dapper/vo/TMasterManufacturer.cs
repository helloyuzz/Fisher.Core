using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterManufacturer",Remarks="")]
   public class TMasterManufacturer {
      [LjkDapperField(Name="ManufacturerID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? ManufacturerID {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerName",SqlDbType=SqlDbType.NVarChar,MaxLength=100,Remarks="FlowID")]
      public virtual string ManufacturerName {
          get;
          set;
      }
      [LjkDapperField(Name="ManufacturerPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ManufacturerPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16,Remarks="科室ID")]
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
      [LjkDapperField(Name="ManufacturerType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ManufacturerType {
          get;
          set;
      }
   }
}