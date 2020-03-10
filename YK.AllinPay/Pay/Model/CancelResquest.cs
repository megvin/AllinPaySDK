using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    /// <summary>
    /// 使用场景：只能撤销当天的交易，全额退款，实时返回退款结果
    /// </summary>
    public class CancelRequest : AbstractModel
    {
        /// <summary>
        /// 商户退款交易单号
        /// </summary>
        public string reqsn { get; set; }
        /// <summary>
        /// 交易金额原订单金额
        /// </summary>
        public long trxamt { get; set; }
        /// <summary>
        /// 原交易单号,原交易的商户交易单号
        /// </summary>
        public string oldreqsn { get; set; }
        /// <summary>
        /// 原交易流水oldreqsn和oldtrxid必填其一建议:商户如果同时拥有oldtrxid和oldreqsn,优先使用oldtrxid
        /// </summary>
        public string oldtrxid { get; set; }
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "reqsn", this.reqsn);
            this.SetParamSimple(map, prefix + "trxamt", this.trxamt);
            this.SetParamSimple(map, prefix + "oldreqsn", this.oldreqsn);
            this.SetParamSimple(map, prefix + "oldtrxid", this.oldtrxid);
        }
    }
}
