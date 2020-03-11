using CrossBorder.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YK.AllinPay;

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
                orderNo = DateTime.Now.ToFileTime().ToString(),
                orderType = "I",
                billmode = "2",
                assureCode = "340126067U",
                ebpCode = "340126067U",
                ebpName = "合肥贝果供应链管理有限公司",
                ebcCode = "340126067U",
                ebcName = "电商企业名称",
                goodsValue = 80,
                freight = 10,
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
                ciqbarcode = "HSbm",
                itemNo = "SKUno",
                itemName = "XYZ保健品",
                specifications = "500",
                itemDescribe = "好东西必须来",
                barCode = "20001200030",
                unit = "瓶",
                qty = 1,
                unit1 = "",
                qty1 = 1,
                price = 80,
                totalPrice = 80,
                weight = 300,
                netweight = 200,
                currency = "142",
                country = "英国",
                note = "",
            });

            string orderStr = JsonConvert.SerializeObject(order);

            var msg = new BDCBMessage() { CompanyCode = "gscode", Data = orderStr, MsgType = "Order", CheckCode = "md5" };

            var msgstr = JsonConvert.SerializeObject(msg);



            var test = new Class1();
            //test.testfile();
        }
    }
}
