using System;
using System.Collections.Generic;
using uniondemo.com.allinpay.syb;
using YK.AllinPay.Pay;
using YK.AllinPay.Pay.Model;
using YK.AllinPay.Trx;

namespace YK.AllinPay
{
    public class Class1
    {
        public void pay()
        {
            //SybWxPayService sybService = new SybWxPayService();
            AllinPayClient client = new AllinPayClient();
            var req = new UnionOrderRequest()
            {
                trxamt =1,
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
                validtime =100

            };

            //   Dictionary<String, String> rsp = sybService.pay(1, DateTime.Now.ToFileTime().ToString(), "W01", "商品内容", "备注", "", "", "http://baidu.com", "", "", "", "");


            var rsp = client.pay(req);


        }

        public void query()
        {
            var req = new QueryRequest()
            {
                trxid = "112024090001369129"
            };
            var clinet = new AllinPayClient();
            var rsp = clinet.query(req);
        }

        public void cancel()
        {
            var req = new CancelRequest()
            {
                reqsn = DateTime.Now.ToFileTime().ToString(),
                trxamt =1,
                oldtrxid = "112024090001369129"
            };
            var clinet = new AllinPayClient();
            var rsp = clinet.cancel(req);
        }


        public void close()
        {
            var req = new CloseRequest()
            {
                oldtrxid = "112024090001369129"
            };
            var clinet = new AllinPayClient();
            var rsp = clinet.close(req);
        }

        public void testfile()
        {
            var clinet = new TrxClinet();
            clinet.trxfile(DateTime.Today.AddDays(-1));
        }
    }
}
