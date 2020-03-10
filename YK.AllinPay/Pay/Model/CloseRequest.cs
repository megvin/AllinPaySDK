using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    /// <summary>
    /// 对于处理中的交易,可调用该接口直接将未付款的交易进行关闭。
    /// </summary>
    public class CloseRequest : AbstractModel
    {
        public string oldreqsn { get; set; }
        public string oldtrxid { get; set; }
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "oldreqsn", this.oldreqsn);
            this.SetParamSimple(map, prefix + "oldtrxid", this.oldtrxid);
        }
    }
}
