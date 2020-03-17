using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using uniondemo.com.allinpay.syb;
using YK.AllinPay;
using YK.AllinPay.Common;
using YK.AllinPay.Customspush;
using YK.AllinPay.Oms;

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

            //var helper = new QdCustomsHelper();
            //helper.test();


           var test = new Class1();
            //test.testfile();

            var oms = new OmsTest();
            oms.test();

        }
    }
}
