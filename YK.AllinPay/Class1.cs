using System;
using System.Collections.Generic;
using uniondemo.com.allinpay.syb;
using YK.AllinPay.Pay;

namespace YK.AllinPay
{
    public class Class1
    {
        public void pay()
        {
            SybWxPayService sybService = new SybWxPayService();
            UnionOrderPayClient client = new UnionOrderPayClient();
            var req = new UnionOrderPayRequest()
            {
                trxamt = "1",
                reqsn = DateTime.Now.ToFileTime().ToString(),
                paytype = "W01",
                body = "测试商品",
                remark = "测试备注",
                acct = "",
                authcode = "",

                notify_url = "http://www.baidu.com",
                limit_pay = "",
                idno = "",
                truename = "",
                asinfo = "",

            };

            //   Dictionary<String, String> rsp = sybService.pay(1, DateTime.Now.ToFileTime().ToString(), "W01", "商品内容", "备注", "", "", "http://baidu.com", "", "", "", "");


            var rsp = client.pay(req);


        }
    }
}
