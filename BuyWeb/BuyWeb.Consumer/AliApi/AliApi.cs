using BuyWeb.Consumer.AliApi.AliApiDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using static Newtonsoft.Json.JsonConvert;



namespace BuyWeb.Consumer.AliApi
{
    public class AliApi
    {
        private static string AliUrl => ConfigurationManager.AppSettings["AliUrl"]?.ToString();
        private static string AliAppKey => ConfigurationManager.AppSettings["AliAppKey"]?.ToString();

        private static string AliAppSecret => ConfigurationManager.AppSettings["AliAppSecret"]?.ToString();

        /// <summary>
        /// 根据搜索信息搜索商品列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public AliGoodSerarchRes GetAliGoodsList(AliGoodSerarchReq req)
        {
            AliGoodSerarchRes res = new AliGoodSerarchRes();
            TbkItemGetRequest request = new TbkItemGetRequest()
            {
                Fields = "num_iid,title,pict_url,small_images,reserve_price,zk_final_price,user_type,provcity,item_url,seller_id,volume,nick",
                Q = req.QueryKey,
                Cat = req.Cat,
                EndPrice = req.EndPrice,
                EndTkRate = req.EndTkRate,
                IsOverseas = req.IsOverseas,
                IsTmall = req.IsTmall,
                Itemloc = req.Itemloc,
                PageNo = req.PageNo,
                PageSize = req.PageSize,
                Platform = req.Platform,
                Sort = req.Sort,
                StartPrice = req.StartPrice,
                StartTkRate = req.StartTkRate
            };
            ITopClient client = new DefaultTopClient(AliUrl, AliAppKey, AliAppSecret);

            TbkItemGetResponse rsp = client.Execute(request);
            res = DeserializeObject<AliGoodSerarchRes>(SerializeObject(rsp));
            return res;
        }

        /// <summary>
        /// 获取商品详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public AliGoodDetailRes GetGoodDetail(AliGoodDetailReq req)
        {
            AliGoodDetailRes res = new AliGoodDetailRes();
            ITopClient client = new DefaultTopClient(AliUrl, AliAppKey, AliAppSecret);
            TbkItemInfoGetRequest request = new TbkItemInfoGetRequest()
            {
                Ip = req.Ip,
                NumIids = req.NumIids,
                Platform = req.Platform
            };
            TbkItemInfoGetResponse rsp = client.Execute(request);
            res = DeserializeObject<AliGoodDetailRes>(SerializeObject(rsp));
            return res;
        }


    }
}
