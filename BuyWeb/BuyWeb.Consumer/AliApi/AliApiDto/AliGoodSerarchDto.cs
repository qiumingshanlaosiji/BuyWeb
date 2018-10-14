using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Consumer.AliApi.AliApiDto
{
    /// <summary>
    /// ali商品查询入参
    /// </summary>
    public class AliGoodSerarchReq
    {
        /// <summary>
        /// 否
        /// 查询词
        /// eg:女装
        /// </summary>
        public string QueryKey { get; set; }

        /// <summary>
        /// 后台类目ID，用,分割，最大10个，该ID可以通过taobao.itemcats.get接口获取到
        /// </summary>
        public string Cat { get; set; }

        /// <summary>
        /// 折扣价范围上限，单位：元
        /// </summary>
        public Nullable<long> EndPrice { get; set; }

        /// <summary>
        /// 淘客佣金比率下限，如：1234表示12.34%
        /// </summary>
        public Nullable<long> EndTkRate { get; set; }

        /// <summary>
        /// 需返回的字段列表
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否海外商品，设置为true表示该商品是属于海外商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public Nullable<bool> IsOverseas { get; set; }

        /// <summary>
        /// 是否商城商品，设置为true表示该商品是属于淘宝商城商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public Nullable<bool> IsTmall { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public string Itemloc { get; set; }

        /// <summary>
        /// 第几页，默认：１
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 链接形式：1：PC，2：无线，默认：１
        /// </summary>
        public Nullable<long> Platform { get; set; }

        /// <summary>
        /// 排序_des（降序），排序_asc（升序），销量（total_sales），淘客佣金比率（tk_rate）， 累计推广量（tk_total_sales），总支出佣金（tk_total_commi）
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 折扣价范围下限，单位：元
        /// </summary>
        public Nullable<long> StartPrice { get; set; }

        /// <summary>
        /// 淘客佣金比率上限，如：1234表示12.34%
        /// </summary>
        public Nullable<long> StartTkRate { get; set; }
    }

    /// <summary>
    /// ali商品查询出参
    /// </summary>
    public class AliGoodSerarchRes : AliResponseBase
    {
        /// <summary>
        /// 客商品
        /// </summary>
        public List<AliGoodSerarchResResult> Results { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        public long TotalResults { get; set; }


    }

    /// <summary>
    /// ali商品查询商品信息
    /// </summary>
    public class AliGoodSerarchResResult
    {
        
        /// <summary>
        /// 淘客地址
        /// </summary>
        public string ClickUrl { get; set; }

        /// <summary>
        /// 商品地址
        /// </summary>
        public string ItemUrl { get; set; }

        /// <summary>
        /// 卖家昵称
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
        /// 宝贝所在地
        /// </summary>
        public string Provcity { get; set; }

        /// <summary>
        /// 商品一口价格
        /// </summary>
        public string ReservePrice { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        public long SellerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ShopTitle { get; set; }

        /// <summary>
        /// 商品小图列表
        /// </summary>
       
        public List<string> SmallImages { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TkRate { get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        public string ZkFinalPriceWap { get; set; }

    }
}
