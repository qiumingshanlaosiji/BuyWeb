using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Consumer.AliApi.AliApiDto
{
    /// <summary>
    /// 阿里商品详情查询 简版
    /// </summary>
    public class AliGoodDetailReq
    {
        /// <summary>
        /// ip地址，影响邮费获取，如果不传或者传入不准确，邮费无法精准提供
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 商品ID串，用,分割，最大40个
        /// </summary>
        public string NumIids { get; set; }

        /// <summary>
        /// 链接形式：1：PC，2：无线，默认：１
        /// </summary>
        public Nullable<long> Platform { get; set; }
    }

    public class AliGoodDetailRes:AliResponseBase
    {
        public List<AliGoodDetailResReult> Results { get; set; }
    }

    public class AliGoodDetailResReult
    {
        /// <summary>
        /// 叶子类目名称
        /// </summary>
        public string CatLeafName { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        public string CatName { get; set; }

        /// <summary>
        /// 是否包邮
        /// </summary>
        public bool FreeShipment { get; set; }

        /// <summary>
        /// 好评率是否高于行业均值
        /// </summary>
        public bool HGoodRate { get; set; }

        /// <summary>
        /// 成交转化是否高于行业均值
        /// </summary>
        public bool HPayRate30 { get; set; }

        /// <summary>
        /// 退款率是否低于行业均值
        /// </summary>
        public bool IRfdRate { get; set; }

        /// <summary>
        /// 是否加入消费者保障
        /// </summary>
        public bool IsPrepay { get; set; }

        /// <summary>
        /// 商品链接
        /// </summary>
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品库类型，支持多库类型输出，以“，”区分，1:营销商品主推库
        /// </summary>
        public string MaterialLibType { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public long NumIid { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        public string PictUrl { get; set; }

        /// <summary>
        /// 商品所在地
        /// </summary>
        public string Provcity { get; set; }

        /// <summary>
        /// 卖家等级
        /// </summary>
        public long Ratesum { get; set; }

        /// <summary>
        /// 商品一口价格
        /// </summary>
        public string ReservePrice { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        public long SellerId { get; set; }

        /// <summary>
        /// 店铺dsr 评分
        /// </summary>
        public long ShopDsr { get; set; }

        /// <summary>
        /// 商品小图列表
        /// </summary>

        public List<string> SmallImages { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 卖家类型，0表示集市，1表示商城
        /// </summary>
        public long UserType { get; set; }

        /// <summary>
        /// 30天销量
        /// </summary>
        public long Volume { get; set; }

        /// <summary>
        /// 商品折扣价格
        /// </summary>
        public string ZkFinalPrice { get; set; }
    }
}
