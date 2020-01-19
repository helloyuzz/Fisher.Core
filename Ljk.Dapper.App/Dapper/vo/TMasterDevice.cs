using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterDevice",Remarks="")]
   public class TMasterDevice {
      [LjkDapperField(Name="DeviceID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4,Remarks="序号")]
      public virtual int? DeviceID {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceName",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100,Remarks="FlowID")]
      public virtual string DeviceName {
          get;
          set;
      }
      [LjkDapperField(Name="DevicePinYin",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string DevicePinYin {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceCode",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string DeviceCode {
          get;
          set;
      }
      [LjkDapperField(Name="IsConnected",SqlDbType=SqlDbType.Bit,MaxLength=1,Remarks="科室ID")]
      public virtual bool? IsConnected {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DeviceType {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeTypeID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? SterilizeTypeID {
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
      [LjkDapperField(Name="IsBDRequired",SqlDbType=SqlDbType.Bit,MaxLength=1)]
      public virtual bool? IsBDRequired {
          get;
          set;
      }
      [LjkDapperField(Name="MinWorkTime",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? MinWorkTime {
          get;
          set;
      }
      [LjkDapperField(Name="DeviceWorkType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DeviceWorkType {
          get;
          set;
      }
      [LjkDapperField(Name="MinReviewTime",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? MinReviewTime {
          get;
          set;
      }
      [LjkDapperField(Name="MaxReviewTime",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? MaxReviewTime {
          get;
          set;
      }
      [LjkDapperField(Name="IntervalReviewTime",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? IntervalReviewTime {
          get;
          set;
      }
      [LjkDapperField(Name="MinBDTime",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? MinBDTime {
          get;
          set;
      }
      [LjkDapperField(Name="ConnectPath",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string ConnectPath {
          get;
          set;
      }
      [LjkDapperField(Name="OrgID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? OrgID {
          get;
          set;
      }
   }
}