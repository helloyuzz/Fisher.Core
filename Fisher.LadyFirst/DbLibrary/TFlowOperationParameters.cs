using System;
using Fisher.Core;
using System.Data;

namespace Fisher.Core.DbLibrary {
   [Serializable]
   [FisherField(Name="TFlowOperationParameters",Remarks="")]
   public class TFlowOperationParameters {
      [FisherField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [FisherField(Name="DeviceID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? DeviceID {
          get;
          set;
      }
      [FisherField(Name="BatchID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? BatchID {
          get;
          set;
      }
      [FisherField(Name="DeviceBatchNumber",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? DeviceBatchNumber {
          get;
          set;
      }
      [FisherField(Name="OperationParameters",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string OperationParameters {
          get;
          set;
      }
      [FisherField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [FisherField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [FisherField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CreatedBy {
          get;
          set;
      }
      [FisherField(Name="UpdatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UpdatedBy {
          get;
          set;
      }
      [FisherField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
   }
}