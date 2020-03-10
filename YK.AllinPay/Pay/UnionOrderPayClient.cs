using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;

namespace YK.AllinPay.Pay
{
   public class UnionOrderPayClient: AbstractClient
    {
        public UnionOrderPayResponse pay(UnionOrderPayRequest req)
        {
            UnionOrderPayResponse rsp = null;
            try
            {
                var strResp = this.InternalRequest(req, "pay");
                rsp = JsonConvert.DeserializeObject<UnionOrderPayResponse>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new Exception(e.Message);
            }
            return rsp;
        }
    }
}
