using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oms.Model
{
    /// <summary>
    /// 海恒达消息报文
    /// </summary>
    public class OmsMessage
    {
        /// <summary>
        /// 企业代码：海恒达系统分配的企业代码，必填
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 报文类型：订单为Order，必填
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 具体的业务数据，如订单的话对应 BDCBMsgOrder 串行化后的数据，必填
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 报文校验码：先把报文与密钥前后连接,把连接后的字符串做MD5编码,把MD5编码后的数据进行Base64编码,即为校验码；必填。
        /// 报文是Data部分的数据
        /// </summary>
    	public string CheckCode { get; set; }
    
    }

    /// <summary>
    /// 海恒达订单报文
    /// </summary>
    public class BDCBMsgOrder
    {
        /// <summary>
        /// 表头信息
        /// </summary>
        public BDCBOrderHead OrderHead { get; set; }

        /// <summary>
        /// 表体信息
        /// </summary>
        public List<BDCBOrderList> OrderList { get; set; }
    }

    /// <summary>
    /// 订单表头信息
    /// </summary>
    public class BDCBOrderHead
    {
        /// <summary>
        /// 订单编号，必填
        /// </summary>
        public string orderNo { get; set; }
        /// <summary>
        /// 订单类型，必填，I进口
        /// </summary>
        public string orderType { get; set; }

        /// <summary>
        /// 模式代码，必填,模式代码 1一般模式 ； 2保税模式
        /// </summary>
        public string billmode { get; set; }
        /// <summary>
        /// 担保企业编号，必填
        /// </summary>
        public string assureCode { get; set; }

        /// <summary>
        /// 电商平台代码，必填
        /// 电商平台的海关注册登记编号
        /// </summary>
        public string ebpCode { get; set; }
        /// <summary>
        /// 电商平台名称，必填
        /// 电商平台的海关注册登记名称
        /// </summary>
        public string ebpName { get; set; }
        /// <summary>
        /// 电商企业代码，必填
        /// 电商企业的海关注册登记编号。
        /// </summary>
        public string ebcCode { get; set; }
        /// <summary>
        /// 电商企业名称，必填
        /// 电商企业的海关注册登记名称。
        /// </summary>
        public string ebcName { get; set; }
        /// <summary>
        /// 商品价格，必填
        /// 商品实际成交价，含非现金抵扣金额。
        /// </summary>
        public decimal goodsValue { get; set; }
        /// <summary>
        /// 运杂费，必填
        /// 不包含在商品价格中的运杂费，无则填写"0"。
        /// </summary>
        public decimal freight { get; set; }
        /// <summary>
        /// 非现金抵扣金额，必填
        /// 使用积分、虚拟货币、代金券等非现金支付金额，无则填写"0"。
        /// </summary>
        public decimal discount { get; set; }
        /// <summary>
        /// 代扣税款，必填
        /// 企业预先代扣的税款金额，无则填写“0”
        /// </summary>
        public decimal taxTotal { get; set; }
        /// <summary>
        /// 实际支付金额，必填
        /// 商品价格+运杂费+代扣税款-非现金抵扣金额，与支付凭证的支付金额一致。
        /// </summary>
        public decimal acturalPaid { get; set; }
        /// <summary>
        /// 币制，必填
        /// 限定为人民币，填写“142”。
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// 订购人注册号,必填
        /// 订购人的交易平台注册号。
        /// </summary>
        public string buyerRegNo { get; set; }
        /// <summary>
        /// 订购人姓名，必填
        /// </summary>
        public string buyerName { get; set; }
        /// <summary>
        /// 订购人证件类型，必填
        /// 1-身份证,2-其它。限定为身份证，填写“1”。
        /// </summary>
        public string buyerIdType { get; set; }
        /// <summary>
        /// 订购人证件号码，必填
        /// 订购人的身份证件号码。
        /// </summary>
        public string buyerIdNumber { get; set; }
        /// <summary>
        /// 支付企业代码
        /// 支付企业的海关注册登记编号。
        /// </summary>
        public string payCode { get; set; }
        /// <summary>
        /// 支付企业名称
        /// 支付企业在海关注册登记的企业名称。
        /// </summary>
        public string payName { get; set; }
        /// <summary>
        /// 支付交易编号
        /// 支付企业唯一的支付流水号。
        /// </summary>
        public string payTrCsactionId { get; set; }
        /// <summary>
        /// 商品批次号
        /// </summary>
        public string batchNumbers { get; set; }        
        /// <summary>
        /// 数量(对应总署包裹数，限定为1),必填
        /// </summary>
        public int quantity { get; set; }


        /// <summary>
        /// 发货人名称,必填
        /// </summary>
        public string senderusername { get; set; }
        /// <summary>
        /// 发货人省份,必填
        /// </summary>
        public string senderuserprov { get; set; }
        /// <summary>
        /// 发货人市,必填
        /// </summary>
        public string senderusercity { get; set; }
        /// <summary>
        /// 发货人区县,必填
        /// </summary>
        public string senderuserdistrict { get; set; }
        /// <summary>
        /// 发货人地址,必填
        /// </summary>
        public string senderuseraddress { get; set; }
        /// <summary>
        /// 发货人电话，必填
        /// </summary>
        public string senderusertelephone { get; set; }
        /// <summary>
        /// 发货人所在国,必填
        /// </summary>
        public string senderusercountry { get; set; }


        /// <summary>
        /// 收货人姓名，必填
        /// </summary>
        public string consignee { get; set; }
        /// <summary>
        /// 收货人电话，必填
        /// </summary>
        public string consigneeTelephone { get; set; }
        /// <summary>
        /// 收货人省，必填
        /// </summary>
        public string consigneeprov { get; set; }
        /// <summary>
        /// 收货人市，必填
        /// </summary>
        public string consigneecity { get; set; }
        /// <summary>
        /// 收货人区县，必填
        /// </summary>
        public string consigneedistrict { get; set; }
        /// <summary>
        /// 收货地址，必填
        /// </summary>
        public string consigneeAddress { get; set; }
        /// <summary>
        /// 收货人所在国，必填
        /// </summary>
        public string consigneecountry { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string note { get; set; }
    }

    /// <summary>
    /// 订单表体信息
    /// </summary>
    public class BDCBOrderList
    {
        /// <summary>
        /// HS编码，必填
        /// </summary>
        public string ciqbarcode { get; set; }

        /// <summary>
        /// 企业商品货号，必填
        /// 电商企业自定义的商品货号（SKU）。
        /// 保税模式下，须填写商品的账册备案序号。 
        /// </summary>
        public string itemNo { get; set; }
        /// <summary>
        /// 企业商品名称，必填
        /// 交易平台销售商品的中文名称。
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 规格型号，必填
        /// </summary>
        public string specifications { get; set; }

        /// <summary>
        /// 企业商品描述
        /// 交易平台销售商品的描述信息。
        /// </summary>
        public string itemDescribe { get; set; }
        /// <summary>
        /// 条形码，必填
        /// 国际通用的商品条形码，一般由前缀部分、制造厂商代码、商品代码和校验码组成。
        /// </summary>
        public string barCode { get; set; }
        /// <summary>
        /// 申报单位，必填
        /// 填写海关标准的参数代码，参照《JGS-20 海关业务代码集》- 计量单位代码。
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// 申报数量，必填
        /// 商品实际数量。
        /// </summary>
        public decimal qty { get; set; }

        /// <summary>
        /// 法定单位，必填
        /// 填写海关标准的参数代码，参照《JGS-20 海关业务代码集》- 计量单位代码。
        /// </summary>
        public string unit1 { get; set; }
        /// <summary>
        /// 法定数量，必填
        /// </summary>
        public decimal qty1 { get; set; }

        /// <summary>
        /// 第二单位，如果有第二法定单位则必填
        /// 填写海关标准的参数代码，参照《JGS-20 海关业务代码集》- 计量单位代码。
        /// </summary>
        public string unit2 { get; set; }
        /// <summary>
        /// 第二数量，如果有第二法定单位则必填
        /// </summary>
        public decimal? qty2 { get; set; }

        /// <summary>
        /// 单价，必填
        /// 商品单价。赠品单价填写为“0”。
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// 总价，必填
        /// 商品总价，等于单价乘以数量。
        /// </summary>
        public decimal totalPrice { get; set; }

        /// <summary>
        /// 毛重，必填
        /// 单位为千克。
        /// </summary>
        public decimal weight { get; set; }
        /// <summary>
        /// 净重，必填
        /// 单位为千克。
        /// </summary>
        public decimal netweight { get; set; }

        /// <summary>
        /// 币制，必填
        /// 限定为人民币，填写“142”。
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// 原产国，必填
        /// 填写海关标准的参数代码，参照《JGS-20 海关业务代码集》-国家（地区）代码表。
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 备注
        /// 促销活动，商品单价偏离市场价格的，可以在此说明。
        /// </summary>
        public string note { get; set; }
    }
}
