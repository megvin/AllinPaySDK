using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    /// <summary>
    /// 使用场景：支持部分金额退款，隔天交易退款
    ///注：含单品优惠交易只能整单退款，不支持部分退款
    /// </summary>
    public class RefundRequest : AbstractModel
    {
        public string reqsn { get; set; }


        public string remark { get; set; }

        /// <summary>
        /// 原交易流水
        /// </summary>
        public string oldtrxid { get; set; }
        /// <summary>
        /// 原交易订单号
        /// </summary>
        public string oldreqsn { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public long trxamt { get; set; }
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "reqsn", this.reqsn);
            this.SetParamSimple(map, prefix + "trxamt", this.trxamt);
            this.SetParamSimple(map, prefix + "oldreqsn", this.oldreqsn);
            this.SetParamSimple(map, prefix + "oldtrxid", this.oldtrxid);
            this.SetParamSimple(map, prefix + "remark", this.remark);
        }
    }
}
