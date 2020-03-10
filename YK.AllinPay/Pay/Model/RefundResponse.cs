using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
   public class RefundResponse: AbstractResponseModel
    {
        /// <summary>
        /// 交易单号收银宝平台的退款交易流水号
        /// </summary>
        public string trxid { get; set; }
        /// <summary>
        /// 商户的退款交易订单号
        /// </summary>
        public string reqsn { get; set; }

        public string fintime { get; set; }



        /// <summary>
        /// 手续费
        /// </summary>
        public long fee { get; set; }

        public string trxcode { get; set; }
    }
}
