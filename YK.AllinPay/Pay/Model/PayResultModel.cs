using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay.Model
{
    public class PayResultModel
    {
        public string appid { get; set; }
        public string outtrxid { get; set; }
        public string trxcode { get; set; }
        /// <summary>
        /// 收银宝交易单号
        /// </summary>
        public string trxid { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        public long trxamt { get; set; }
        /// <summary>
        /// 交易请求日期yyyymmdd
        /// </summary>
        public string trxdate { get; set; }
        /// <summary>
        /// 交易完成时间yyyymmddhhmmss
        /// </summary>
        public string paytime { get; set; }
        /// <summary>
        /// 渠道流水号
        /// </summary>
        public string chnltrxid { get; set; }

        public string trxstatus { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        public string cusid { get; set; }
        /// <summary>
        /// 终端编号
        /// </summary>
        public string termno { get; set; }

        /// <summary>
        /// 终端批次号
        /// </summary>
        public string termbatchid { get; set; }

        /// <summary>
        /// 终端流水号
        /// </summary>
        public string termtraceno { get; set; }

        /// <summary>
        /// 终端授权码
        /// </summary>
        public string termauthno { get; set; }

        /// <summary>
        /// 终端参考号
        /// </summary>
        public string termrefnum { get; set; }
        /// <summary>
        /// 业务关联内容
        /// </summary>
        public string trxreserved { get; set; }
        /// <summary>
        /// 原交易流水
        /// </summary>
        public string srctrxid { get; set; }

        /// <summary>
        ///  业务流水 统一下单对应的reqsn订单号
        /// </summary>
        public string cusorderid { get; set; }

        /// <summary>
        /// 交易账号
        /// </summary>
        public string acct { get; set; }
        /// <summary>
        /// 手续费
        /// </summary>
        public long fee { get; set; }

        public string signtype { get; set; }
        /// <summary>
        /// 渠道子商户号
        /// </summary>
        public string cmid { get; set; }

        public string chnlid { get; set; }

        public string sign { get; set; }



    }
}
