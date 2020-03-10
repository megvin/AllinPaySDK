using System;
using System.Collections.Generic;
using System.Text;

namespace YK.AllinPay.Common
{
    public abstract class AbstractResponseModel
    {

        public string cusid { get; set; }
        public string appid { get; set; }

        public string randomstr { get; set; }

        public string retcode { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string retmsg { get; set; }

        public string trxstatus { get; set; }
        public string sign { get; set; }
    }
}
