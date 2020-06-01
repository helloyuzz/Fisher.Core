using System;
using Fisherman.Core;
using System.Data;

namespace App.DbLibrary {
   [Serializable]
   [FisherField(Name="TFlowClean",Remarks="")]
   public class TFlowClean {
      [FisherField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,CanotDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [FisherField(Name="CleanUserID",SqlDbType=SqlDbType.Int,CanotDBNull =false,MaxLength=4)]
      public virtual int? CleanUserID {
          get;
          set;
      }
      [FisherField(Name="ProcessID",SqlDbType=SqlDbType.Int,CanotDBNull =false,MaxLength=4)]
      public virtual int? ProcessID {
          get;
          set;
      }
      [FisherField(Name="BatchNumberID",SqlDbType=SqlDbType.Int,CanotDBNull =false,MaxLength=4)]
      public virtual int? BatchNumberID {
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
      [FisherField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,CanotDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
   }
}