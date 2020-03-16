using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uniondemo.com.allinpay.syb
{
    public class AppConstants
    {
        public static String APPID = "00000000";
        public static String CUSID = "990440153996000";
        public static String APPKEY = "43df939f1e7f5c6909b3f4b63f893994";
        public static String APIVERSION = "11";
        public static String API_URL = "https://vsp.allinpay.com/apiweb/";

        #region 海关推送部分常量
        /// <summary>
        /// 支付海关推送相关
        /// </summary>
        public static string VISITOR_ID = "MCT";
        /// <summary>
        /// 版本号
        /// </summary>
        public static string VERSION = "v5.6";
        /// <summary>
        /// 报关用的商户号
        /// </summary>
        public static string MCHT_ID { get; set; }

        /// <summary>
        /// 支付用的商户号
        /// </summary>
        public static string CUS_ID { get; set; }
        /// <summary>
        /// 海关类别
        /// </summary>
        public static string CUSTOMS_CODE = "HG023";

        public static string ESHOP_ENT_CODE = "340126067U";
        public static string ESHOP_ENT_NAME = "合肥贝果供应链管理有限公司";

        public static string PAY_MD5KEY = "abcdeef";

        #endregion 

    }
}