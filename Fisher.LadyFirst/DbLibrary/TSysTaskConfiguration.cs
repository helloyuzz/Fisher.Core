using System;
using Fisherman.Core;
using System.Data;

namespace App.DbLibrary {
   [Serializable]
   [FisherField(Name="TSysTaskConfiguration",Remarks="")]
   public class TSysTaskConfiguration {
      [FisherField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=10,Remarks="序号")]
      public virtual int? ID {
          get;
          set;
      }
      [FisherField(Name="TaskIndex",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10,Remarks="ConfigurationKey")]
      public virtual int? TaskIndex {
          get;
          set;
      }
      [FisherField(Name="TaskType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10)]
      public virtual int? TaskType {
          get;
          set;
      }
      [FisherField(Name="IsRequired",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsRequired {
          get;
          set;
      }
      [FisherField(Name="OrgType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=10,Remarks="科室ID")]
      public virtual int? OrgType {
          get;
          set;
      }
      [FisherField(Name="Remark",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=200)]
      public virtual string Remark {
          get;
          set;
      }
   }
}