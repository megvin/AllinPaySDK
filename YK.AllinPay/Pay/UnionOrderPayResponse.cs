using System;
using System.Collections.Generic;
using System.Text;

namespace YK.AllinPay.Pay
{
   public class UnionOrderPayResponse
    {
        public string retcode { get; set; }
        public string retmsg { get; set; }
        public string cusid { get; set; }
        public string appid { get; set; }
        public string trxid { get; set; }
        public string chnltrxid { get; set; }
        public string reqsn { get; set; }
        public string randomstr { get; set; }
        public string trxstatus { get; set; }
        public string fintime { get; set; }
        public string errmsg { get; set; }
        public string payinfo { get; set; }
        public string sign { get; set; }

    }
}
