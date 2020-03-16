using System;
using System.Collections.Generic;
using System.Text;
using uniondemo.com.allinpay.syb;

namespace YK.AllinPay.customspush
{
    public class QdCustmosModel
    {
        public QdCustmosModel()
        {
            MCHT_ID = AppConstants.MCHT_ID;
            CUS_ID = AppConstants.CUS_ID;
            ESHOP_ENT_CODE = AppConstants.ESHOP_ENT_CODE;
            ESHOP_ENT_NAME = AppConstants.ESHOP_ENT_NAME;
            CUSTOMS_CODE = AppConstants.CUSTOMS_CODE;
            PAPER_TYPE = "01";
        }
        private string MCHT_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string TRANS_DATETIME { get; set; }
        //public string SIGN_MSG { get; set; }

        /// <summary>
        /// 海关编码
        /// </summary>
        private string CUSTOMS_CODE { get; set; }
        /// <summary>
        /// 支付渠道
        /// </summary>
        public string PAYMENT_CHANNEL { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        private string CUS_ID { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public string PAYMENT_DATETIME { get; set; }
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MCHT_ORDER_NO { get; set; }

        public string PAYMENT_ORDER_NO { get; set; }
        public long PAYMENT_AMOUNT { get; set; }
        /// <summary>
        /// 海关分配的电商平台代码
        /// </summary>
        private string ESHOP_ENT_CODE { get; set; }
        /// <summary>
        /// 海关分配的电商平台名称
        /// </summary>
        private string ESHOP_ENT_NAME { get; set; }

        public string PAYER_NAME { get; set; }
        private string PAPER_TYPE { get; set; }
        public string PAPER_NUMBER { get; set; }
        public string PAPER_PHONE { get; set; }
        public string MEMO { get; set; }
        public string MAIN_PAYMENT_ORDER_NO { get; set; }

        private string GetHeadXml()
        {
            StringBuilder sb = new StringBuilder("<HEAD>");
            sb.Append($"<VERSION>{"v5.6"}</VERSION>");
            sb.Append($"<MCHT_ID>{this.MCHT_ID}</MCHT_ID>");
            sb.Append($"<ORDER_NO>{this.ORDER_NO}</ORDER_NO>");
            sb.Append($"<TRANS_DATETIME>{DateTime.Now.ToString("yyyyMMddHHssmm")}</TRANS_DATETIME>");
            sb.Append($"<CHARSET>1</CHARSET>");
            sb.Append($"<SIGN_TYPE>1</SIGN_TYPE>");
            sb.Append($"<SIGN_MSG>{this.GetSIGN_MSG()}</SIGN_MSG>");
            sb.Append("</HEAD>");

            return sb.ToString();

        }
        public string GetBodyXml()
        {
            StringBuilder sb = new StringBuilder("<BODY>");
            sb.Append($"<CUSTOMS_CODE>{this.CUSTOMS_CODE}</CUSTOMS_CODE>");
            sb.Append($"<PAYMENT_CHANNEL>{this.PAYMENT_CHANNEL}</PAYMENT_CHANNEL>");
            sb.Append($"<CUS_ID>{this.CUS_ID}</CUS_ID>");
            sb.Append($"<PAYMENT_DATETIME>{this.PAYMENT_DATETIME}</PAYMENT_DATETIME>");
            sb.Append($"<MCHT_ORDER_NO>{this.MCHT_ORDER_NO}</MCHT_ORDER_NO>");
            sb.Append($"<PAYMENT_CHANNEL>{this.PAYMENT_CHANNEL}</PAYMENT_CHANNEL>");
            sb.Append($"<PAYMENT_CHANNEL>{this.PAYMENT_CHANNEL}</PAYMENT_CHANNEL>");
            sb.Append($"<CUS_ID>{this.CUS_ID}</CUS_ID>");
            sb.Append($"<PAYMENT_DATETIME>{this.PAYMENT_DATETIME}</PAYMENT_DATETIME>");
            sb.Append($"<MCHT_ORDER_NO>{this.MCHT_ORDER_NO}</MCHT_ORDER_NO>");
            sb.Append($"<PAYMENT_ORDER_NO>{this.PAYMENT_ORDER_NO}</PAYMENT_ORDER_NO>");
            sb.Append($"<PAYMENT_AMOUNT>{this.PAYMENT_AMOUNT}</PAYMENT_AMOUNT>");
            sb.Append($"<CURRENCY>156</CURRENCY>");
            sb.Append($"<ESHOP_ENT_CODE>{this.ESHOP_ENT_CODE}</ESHOP_ENT_CODE>");
            sb.Append($"<ESHOP_ENT_NAME>{this.ESHOP_ENT_NAME}</ESHOP_ENT_NAME>");
            sb.Append($"<PAYER_NAME>{this.PAYER_NAME}</PAYER_NAME>");
            sb.Append($"<PAPER_TYPE>{this.PAPER_TYPE}</PAPER_TYPE>");
            sb.Append($"<PAPER_NUMBER>{this.PAPER_NUMBER}</PAPER_NUMBER>");
            sb.Append("<PAPER_PHONE></PAPER_PHONE>");
            sb.Append("<MEMO></MEMO>");
            sb.Append("<MAIN_PAYMENT_ORDER_NO></MAIN_PAYMENT_ORDER_NO>");
            sb.Append("</BODY>");

            return sb.ToString();
        }

        public string GetXml()
        {
            StringBuilder sb = new StringBuilder("<PAYMENT_INFO>");
            sb.Append(GetHeadXml());
            sb.Append(GetBodyXml());
            sb.Append("</PAYMENT_INFO>");
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(sb.ToString()));
        }

      

        private string GetSIGN_MSG()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetBodyXml());
            sb.Append($"<key>{AppConstants.PAY_MD5KEY}</key>");

            return AppUtil.MD5Encrypt2(sb.ToString());


        }



    }
}
