using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay
{
    public class UnionOrderPayRequest : AbstractModel
    {
        public long? trxamt { get; set; }
        /// <summary>
        /// 商户交易单号
        /// </summary>
        public string reqsn { get; set; }


        /// <summary>
        /// 交易方式
        /// </summary>
        public string paytype { get; set; }
        /// <summary>
        /// 订单标题
        /// </summary>
        public string body { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }


        /// <summary>
        /// 支付平台用户标识
        /// </summary>
        public string acct { get; set; }

        //public string authcode { get; set; }


        /// <summary>
        /// 支付平台用户标识
        /// </summary>
        public string notify_url { get; set; }
        public string limit_pay { get; set; }

        /// <summary>
        /// 支付平台用户标识
        /// </summary>
        public string sub_appid { get; set; }

        public string idno { get; set; }
        public string truename { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public int? validtime { get; set; }


        /// <summary>
        /// 分账信息cusid:type:amount;type01按金额，02按比例
        /// </summary>
        public string asinfo { get; set; }


        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "trxamt", this.trxamt);
            this.SetParamSimple(map, prefix + "reqsn", this.reqsn);
            this.SetParamSimple(map, prefix + "paytype", this.paytype);
            this.SetParamSimple(map, prefix + "body", this.body);
            this.SetParamSimple(map, prefix + "remark", this.remark);
            this.SetParamSimple(map, prefix + "acct", this.acct);
            this.SetParamSimple(map, prefix + "authcode", this.authcode);
            this.SetParamSimple(map, prefix + "notify_url", this.notify_url);
            this.SetParamSimple(map, prefix + "limit_pay", this.limit_pay);
            this.SetParamSimple(map, prefix + "sub_appid", this.sub_appid);
            this.SetParamSimple(map, prefix + "idno", this.idno);
            this.SetParamSimple(map, prefix + "truename", this.truename);
            this.SetParamSimple(map, prefix + "asinfo", this.asinfo);
            this.SetParamSimple(map, prefix + "validtime", (this.validtime.HasValue ? this.validtime.Value.ToString() : ""));
            //this.SetParamSimple(map, prefix + "trxamt", this.trxamt);
            //this.SetParamArrayObj(map, prefix + "MediaInfoSet.", this.MediaInfoSet);
            //this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
