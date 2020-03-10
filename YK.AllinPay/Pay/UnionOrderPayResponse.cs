using System;
using System.Collections.Generic;
using System.Text;

namespace YK.AllinPay.Pay
{
   public class UnionOrderPayResponse
    {
        public string retcode { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string retmsg { get; set; }
        public string cusid { get; set; }
        public string appid { get; set; }
        /// <summary>
        /// 交易单号
        /// </summary>
        public string trxid { get; set; }
        /// <summary>
        /// 渠道平台交易单号，例如微信,支付宝平台的交易单号
        /// </summary>
        public string chnltrxid { get; set; }
        /// <summary>
        /// 商户交易单号
        /// </summary>
        public string reqsn { get; set; }
        public string randomstr { get; set; }
        /// <summary>
        /// 交易状态
        /// </summary>
        public string trxstatus { get; set; }
        /// <summary>
        /// 交易完成时间
        /// </summary>
        public string fintime { get; set; }
        /// <summary>
        /// errmsg
        /// </summary>
        public string errmsg { get; set; }
        /// <summary>
        /// 支付串
        /// </summary>
        public string payinfo { get; set; }
        public string sign { get; set; }

    }
}
