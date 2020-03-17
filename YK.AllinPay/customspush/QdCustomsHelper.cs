using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using uniondemo.com.allinpay.syb;

namespace YK.AllinPay.customspush
{
    public class QdCustomsHelper
    {


        public void test()
        {
            var model = new QdCustmosModel()
            {
                ORDER_NO = DateTime.Now.ToString("yyyyMMddHHssmm"),
                TRANS_DATETIME = DateTime.Now.ToString("yyyyMMddHHssmm"),
                PAYMENT_DATETIME = DateTime.Now.ToString("yyyyMMddHHssmm"),
                MCHT_ORDER_NO = "171343370",
                PAYMENT_ORDER_NO = "171343370",
                PAYMENT_AMOUNT = 29600,
                PAYER_NAME = "杨怀华",
                PAPER_NUMBER = "",
                PAPER_PHONE = "13969777534",
                PAYMENT_CHANNEL = "2",
                MAIN_PAYMENT_ORDER_NO = "",
                MEMO = ""
            };
            var data = model.GetPostData();
         
            string result = HttpUtil.postforRest("http://ceshi.allinpay.com/customs/pvcapply", "data=" + data);

            var r = Encoding.UTF8.GetString(Convert.FromBase64String(result));

            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.LoadXml(r);

                var node = xmlDoc.SelectSingleNode("PAYMENT_INFO/BODY");
                var body = node.InnerXml;
                var sign = xmlDoc.SelectSingleNode("PAYMENT_INFO/HEAD/SIGN_MSG").InnerText;

                var newsign = AppUtil.MD5Encrypt($"<BODY>{body}</BODY><key>{AppConstants.PAY_MD5KEY}</key>");
                if (sign == newsign)
                {
                    string code = xmlDoc.SelectSingleNode("PAYMENT_INFO/BODY/RETURN_CODE").InnerText;
                    string msg = xmlDoc.SelectSingleNode("PAYMENT_INFO/BODY/RETURN_MSG").InnerText;
                    if(code.Equals("0000"))
                    {
                        //成功
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

       

    }



}
