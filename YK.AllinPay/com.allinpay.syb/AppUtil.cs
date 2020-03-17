using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace uniondemo.com.allinpay.syb
{
    public class AppUtil
    {
        /// <summary>
        /// 将参数排序组装
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static String BuildParamStr(Dictionary<String, String> param)
        {
            if (param == null || param.Count == 0)
            {
                return "";
            }
            Dictionary<String, String> ascDic = param.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            StringBuilder sb = new StringBuilder();
            foreach (var item in ascDic)
            {
                if (!string.IsNullOrEmpty(item.Value))
                {
                    sb.Append(item.Key).Append("=").Append(item.Value).Append("&");
                }
                
            }

            return sb.ToString().TrimEnd('&');
        }

        public static String signParam(Dictionary<String, String> param, String appkey)
        {
            if (param == null || param.Count == 0)
            {
                return "";
            }
            param.Add("key", appkey);
            String blankStr = BuildParamStr(param);
            return MD5Encrypt(blankStr);

        }

        public static bool validSign(Dictionary<String, String> param, String appkey)
        {
            String signRsp = param["sign"];
            param.Remove("sign");
            String sign = signParam(param, AppConstants.APPKEY);
            return sign.ToLower().Equals(signRsp.ToLower());

        }

        /// <summary>
        /// 将实体转化为json
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ObjectToJson(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;
        }

        /// <summary>
        /// md5加签
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strText));
            return BitConverter.ToString(result).Replace("-", "");
        }

        public static string StringMD5Base64Value(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytHash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            md5.Clear();

            string sTemp = Convert.ToBase64String(bytHash);
            return sTemp;
        }


    }
}