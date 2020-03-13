using CrossBorder.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using uniondemo.com.allinpay.syb;
using YK.AllinPay;
using YK.AllinPay.Common;

namespace YKShip
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            var order = new BDCBMsgOrder();
            order.OrderHead = new BDCBOrderHead()
            {
                orderNo = "132285599606544605",
                orderType = "I",
                billmode = "2",
                assureCode = "340126067U",
                ebpCode = "340126067U",
                ebpName = "合肥贝果供应链管理有限公司",
                ebcCode = "340126067U",
                ebcName = "合肥贝果供应链管理有限公司",
                goodsValue = 80,
                freight = 20,
                discount = 0,
                taxTotal = 0,
                acturalPaid = 100,
                currency = "142",
                buyerRegNo = "13863981314",
                buyerName = "付军",
                buyerIdType = "1",
                buyerIdNumber = "370126198004030073",
                payCode = "312228034T",
                payName = "通联支付网络服务股份有限公司",
                payTrCsactionId = "0001234567",
                batchNumbers = "",
                quantity = 1,
                senderusername = "杨怀华",
                senderuserprov = "山东省",
                senderusercity = "青岛市",
                senderuserdistrict = "李沧区",
                senderuseraddress = "黑龙江路147号湖山美地4.2期",
                senderusertelephone = "13969777534",
                senderusercountry = "中国",
                consignee = "刘晓鹏",
                consigneeTelephone = "13370883245",
                consigneeprov = "山东省",
                consigneecity = "济南市",
                consigneedistrict = "商河县",
                consigneeAddress = "玉皇庙镇商业街",
                consigneecountry = "中国",
                note = "请尽快发货"
            };

            order.OrderList = new List<BDCBOrderList>();
            order.OrderList.Add(new BDCBOrderList()
            {
                ciqbarcode = "2106909090",
                itemNo = "20001002",
                itemName = "测试商品",
                specifications = "20",
                itemDescribe = "",
                barCode = "200010020011",
                unit = "142",
                qty = 1,
                unit1 = "035",
                qty1 = 0.02m,
                price = 80,
                totalPrice = 80,
                weight = 0.3m,
                netweight = 0.02m,
                currency = "142",
                country = "303",
                note = "",
            });

            string orderStr = JsonConvert.SerializeObject(order);
            string checkcode = BdbHelper.StringMD5Base64Value(orderStr+"test_94776e14654ac5d5d58a773193a95af9e42");

            var msg = new BDCBMessage() { CompanyCode = "HFBG", Data = orderStr, MsgType = "Order", CheckCode = checkcode };

            var msgstr = JsonConvert.SerializeObject(msg);

            string url = "http://ceb.bondex.com.cn:8831/Crossborder/Api/CebServices/SendBDCBMsg";
            var result= HttpUtil.CreatePostResponse(url, msgstr, Encoding.UTF8);


            var test = new Class1();
            //test.testfile();
        }
    }
}
