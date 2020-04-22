using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterDeviceDetail",Remarks="")]
   public class TMasterDeviceDetail {
      [LjkDapperField(Name="DetailID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? DetailID {
          get;
          set;
      }
      [LjkDapperField(Name="DetailName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=400)]
      public virtual string DetailName {
          get;
          set;
      }
      [LjkDapperField(Name="DetailPinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string DetailPinYin {
          get;
          set;
      }
      [LjkDapperField(Name="DetailMaintainCycle",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DetailMaintainCycle {
          get;
          set;
      }
      [LjkDapperField(Name="DetailMaintainCycleRemind",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DetailMaintainCycleRemind {
          get;
          set;
      }
      [LjkDapperField(Name="IsRemind",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsRemind {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DeviceID {
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