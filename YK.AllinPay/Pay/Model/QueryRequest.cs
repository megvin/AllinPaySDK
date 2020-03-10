using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    public class QueryRequest : AbstractModel
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string reqsn { get; set; }
        /// <summary>
        /// 平台交易流水 	支付的收银宝平台流水,reqsn和trxid必填其一建议:商户如果同时拥有trxid和reqsn,优先使用trxid
        /// </summary>
        public string trxid { get; set; }
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "reqsn", this.reqsn);
            this.SetParamSimple(map, prefix + "trxid", this.trxid);

        }
    }
}
