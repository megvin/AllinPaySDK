using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YK.AllinPay.Common;
using YK.AllinPay.Pay.Model;

namespace YK.AllinPay.Pay
{
   public class AllinPayClient: AbstractClient
    {
        public UnionOrderResponse pay(UnionOrderRequest req)
        {
            UnionOrderResponse rsp = null;
            try
            {
                var strResp = this.InternalRequest(req, "pay");
                rsp = JsonConvert.DeserializeObject<UnionOrderResponse>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new Exception(e.Message);
            }
            return rsp;
        }

        public QueryResponse query(QueryRequest req)
        {
            QueryResponse rsp = null;
            try
            {
                var strResp = this.InternalRequest(req, "query");

                rsp = JsonConvert.DeserializeObject<QueryResponse>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new Exception(e.Message);
            }
            return rsp;
        }


        public CancelResponse cancel(CancelRequest req)
        {
            CancelResponse rsp = null;
            try
            {
                var strResp = this.InternalRequest(req, "cancel");

                rsp = JsonConvert.DeserializeObject<CancelResponse>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new Exception(e.Message);
            }
            return rsp;
        }


        public CloseResponse close(CloseRequest req)
        {
            CloseResponse rsp = null;
            try
            {
                var strResp = this.InternalRequest(req, "close");

                rsp = JsonConvert.DeserializeObject<CloseResponse>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new Exception(e.Message);
            }
            return rsp;
        }


        public RefundResponse refund(RefundRequest req)
        {
            RefundResponse rsp = null;
            try
            {
                var strResp = this.InternalRequest(req, "refund");

                rsp = JsonConvert.DeserializeObject<RefundResponse>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new Exception(e.Message);
            }
            return rsp;
        }
    }
}
