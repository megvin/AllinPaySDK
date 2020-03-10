using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    public class QueryResponse : AbstractResponseModel
    {
        /// <summary>
        /// 交易单号 平台的交易流水号
        /// </summary>
        public string trxid { get; set; }
        /// <summary>
        ///支付渠道交易单号 如支付宝,微信平台的交易单号
        /// </summary>
        public string chnltrxid { get; set; }
        /// <summary>
        /// 商户订单号 商户的交易订单号
        /// </summary>
        public string reqsn { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        public string trxcode { get; set; }
        public long trxamt { get; set; }
        /// <summary>
        /// 支付平台用户标识
        /// </summary>
        public string acct { get; set; }

        /// <summary>
        /// 交易完成时间 yyyyMMddHHmmss
        /// </summary>
        public string fintime { get; set; }

        public string cmid { get; set; }
        public string chnlid { get; set; }
        public long initamt { get; set; }
        public int fee { get; set; }





    }
}
