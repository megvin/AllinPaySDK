using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    public class CancelResponse:AbstractResponseModel
    {
        /// <summary>
        /// 交易单号
        /// </summary>
        public string trxid { get; set; }

        public string reqsn { get; set; }
        public string fintime { get; set; }
        public string trxcode { get; set; }

    }
}
