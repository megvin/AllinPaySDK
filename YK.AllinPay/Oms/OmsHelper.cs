using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Oms
{
    public class OmsHelper
    {

      

        ///<summary>
        ///电商Sign签名
        ///</summary>
        ///<param name="content">内容</param>
        ///<param name="keyValue">Appkey</param>
        ///<param name="charset">URL编码 </param>
        ///<returns>DataSign签名</returns>
        public static string encrypt(String content, String keyValue, String charset)
        {
            if (keyValue != null)
            {
                return base64(MD5Encrypt(content + keyValue, charset), charset);
            }
            return base64(MD5Encrypt(content, charset), charset);
        }

        /// <summary>
        /// md5加签
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string strText, string charset)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.GetEncoding(charset).GetBytes(strText));
            return BitConverter.ToString(result);
        }

        public static string StringMD5Base64Value(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytHash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            md5.Clear();

            string sTemp = Convert.ToBase64String(bytHash);
            return sTemp;
        }


        /// <summary>
        /// base64编码
        /// </summary>
        /// <param name="str">内容</param>
        /// <param name="charset">编码方式</param>
        /// <returns></returns>
        public static string base64(String str, String charset)
        {
            return Convert.ToBase64String(System.Text.Encoding.GetEncoding(charset).GetBytes(str));
        }
    }
}
