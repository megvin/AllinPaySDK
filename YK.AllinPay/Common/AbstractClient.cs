using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using uniondemo.com.allinpay.syb;

namespace YK.AllinPay.Common
{
    public class AbstractClient
    {
        protected string endPoint { get;  set; }
       
        private Dictionary<String, String> buildBasicParam()
        {
            Dictionary<String, String> paramDic = new Dictionary<String, String>();
            paramDic.Add("cusid", AppConstants.CUSID);
            paramDic.Add("appid", AppConstants.APPID);
            paramDic.Add("version", AppConstants.APIVERSION);
            paramDic.Add("randomstr", DateTime.Now.ToFileTime().ToString());
            return paramDic;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="actionName"></param>
        /// <param name="paramDic">系统参数，不传默认。</param>
        /// <returns></returns>
        protected string InternalRequest(AbstractModel request, string actionName, Dictionary<String, String> basicParam = null)
        {
            if (basicParam == null)
            {
                basicParam = buildBasicParam();
            }
            if (request != null)
            {
                request.ToMap(basicParam, "");
            }
            basicParam.Add("sign", AppUtil.signParam(basicParam, AppConstants.APPKEY));


            string strResp = HttpUtil.CreatePostHttpResponse(AppConstants.API_URL + endPoint+"/"+actionName, basicParam, Encoding.UTF8);

            Dictionary<String, String> rspDic = (Dictionary<String, String>)JsonConvert.DeserializeObject(strResp, typeof(Dictionary<String, String>));
            if ("SUCCESS".Equals(rspDic["retcode"]))//验签
            {
                String signRsp = rspDic["sign"];
                rspDic.Remove("sign");
                String sign = AppUtil.signParam(rspDic, AppConstants.APPKEY);
                if (signRsp.Equals(sign))
                {
                    return strResp;
                }
                else
                    throw new Exception("验签失败");

            }
            else
            {
                throw new Exception(rspDic["retmsg"]);
            }
        }

        protected Dictionary<String, String> InternalRequestDict(AbstractModel request, string actionName, Dictionary<String, String> basicParam = null)
        {
            if (basicParam == null)
            {
                basicParam = buildBasicParam();
            }
            if (request != null)
            {
                request.ToMap(basicParam, "");
            }

            basicParam.Add("sign", AppUtil.signParam(basicParam, AppConstants.APPKEY));


            string strResp = HttpUtil.CreatePostHttpResponse(AppConstants.API_URL + endPoint + "/" + actionName, basicParam, Encoding.UTF8);

            Dictionary<String, String> rspDic = (Dictionary<String, String>)JsonConvert.DeserializeObject(strResp, typeof(Dictionary<String, String>));
            if ("SUCCESS".Equals(rspDic["retcode"]))//验签
            {
                String signRsp = rspDic["sign"];
                rspDic.Remove("sign");
                String sign = AppUtil.signParam(rspDic, AppConstants.APPKEY);
                if (signRsp.Equals(sign))
                {
                    return rspDic;
                }
                else
                    throw new Exception("验签失败");

            }
            else
            {
                throw new Exception(rspDic["retmsg"]);
            }
        }

    }
}
