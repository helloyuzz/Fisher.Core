using System;
using Fisherman.Core;
using System.Data;

namespace App.DbLibrary {
   [Serializable]
   [FisherField(Name="TSysConfiguration",Remarks="ConfigurationKeyaaa")]
   public class TSysConfiguration {
      [FisherField(Name="ConfigurationID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,CanotDBNull=true,MaxLength=10,Remarks="序号")]
      public virtual int? ConfigurationID {
          get;
          set;
      }
      [FisherField(Name="ConfigurationKey",SqlDbType=SqlDbType.NVarChar,CanotDBNull=true,MaxLength=50,Remarks="ConfigurationKey")]
      public virtual string ConfigurationKey {
          get;
          set;
      }
      [FisherField(Name="Value",SqlDbType=SqlDbType.NVarChar,MaxLength=-1)]
      public virtual string Value {
          get;
          set;
      }
      [FisherField(Name="Remark",SqlDbType=SqlDbType.NVarChar,MaxLength=-1)]
      public virtual string Remark {
          get;
          set;
      }
      [FisherField(Name="IsDisabled",SqlDbType=SqlDbType.Bit,CanotDBNull=true,MaxLength=1,Remarks="科室ID")]
      public virtual bool? IsDisabled {
          get;
          set;
      }
      [FisherField(Name="int_field",SqlDbType=SqlDbType.Int,MaxLength=10)]
      public virtual int? int_field {
          get;
          set;
      }
      [FisherField(Name="date_field",SqlDbType=SqlDbType.Date,MaxLength=10)]
      public virtual DateTime? date_field {
          get;
          set;
      }
      [FisherField(Name="datetime_field",SqlDbType=SqlDbType.DateTime,MaxLength=23)]
      public virtual DateTime? datetime_field {
          get;
          set;
      }
      [FisherField(Name="float_field",SqlDbType=SqlDbType.Float,MaxLength=53)]
      public virtual double? float_field {
          get;
          set;
      }
      [FisherField(Name="real_field",SqlDbType=SqlDbType.Real,MaxLength=24)]
      public virtual float? real_field {
          get;
          set;
      }
      [FisherField(Name="char_field",SqlDbType=SqlDbType.Char,MaxLength=10)]
      public virtual string char_field {
          get;
          set;
      }
   }
}