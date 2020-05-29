using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisherman.Core {
    public class FisherMessage {
        internal static readonly TipMessage ConnectionStringIsNull = new TipMessage("连接字符串不能为空。");
        internal static readonly TipMessage PkIsNull = new TipMessage("主键不能为空，该表{0}未设置主键。",1);
        internal static readonly TipMessage IllegalType = new TipMessage("{0}应为{1}类型。",2);
        internal static readonly TipMessage IllegalField = new TipMessage("非法字段{0}，表{1}中不存在。",2);
        internal static readonly TipMessage FieldNotAllowNull = new TipMessage("必填字段{0}不允许为空null。",1);
    }
}
