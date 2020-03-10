using System;
using System.Collections.Generic;
using System.Text;
using uniondemo.com.allinpay.syb;
using YK.AllinPay.Common;

namespace YK.AllinPay.Trx
{
    public class TrxClinet : AbstractClient
    {
        public TrxClinet()
        {
            base.endPoint = "trxfile";
        }

        private Dictionary<String, String> buildBasicParam()
        {
            Dictionary<String, String> paramDic = new Dictionary<String, String>();
            paramDic.Add("cusid", AppConstants.CUSID);
            paramDic.Add("appid", AppConstants.APPID);
            paramDic.Add("randomstr", DateTime.Now.ToFileTime().ToString());
            return paramDic;
        }

        /// <summary>
        /// 下载对账单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public void trxfile(DateTime day)
        {
            try
            {
                var param = buildBasicParam();
                param.Add("date", day.ToString("yyyyMMdd"));

                var dic = this.InternalRequestDict(null, "get", param);
                string fileUrl = "";
               if(dic.ContainsKey("url"))
                {
                    fileUrl = dic["url"];
                }



            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
