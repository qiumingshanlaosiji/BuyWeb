using BuyWeb.Consumer.AliApi.AliApiDto;
using BuyWeb.Service;
using BuyWeb.Service.ThirdApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Top.Api.Response;

namespace BuyWeb.Controllers
{
    [RoutePrefix("api/third")]
    public class ThirdApiController : ApiController
    {
        private IAliApiService _aliApiService;
        private IJDApiService _jDApiService;
        private IVopApiService _vopApiService;

        public ThirdApiController()
        {
            _aliApiService = new AliApiService();
            _jDApiService = new JDApiService();
            _vopApiService = new VopApiService();
        }

        /// <summary>
        /// 阿里商品查询列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost,Route("ali/goodsList")]
        public ApiResult<AliGoodSerarchRes> GetAliGoodsList(AliGoodSerarchReq req)
        {
            return _aliApiService.GetAliGoodsList(req);
        }

        /// <summary>
        /// 获取商品详情
        /// </summary>
        /// <param name="numIids">商品编号串</param>
        /// <param name="ip">ip地址</param>
        /// <param name="platform">平台</param>
        /// <returns></returns>
        [HttpGet, Route("ali/goodDetail")]
        public ApiResult<AliGoodDetailRes> GetAliGoodDetail(string numIids,string ip,int platform)
        {
            AliGoodDetailReq req = new AliGoodDetailReq()
            {
                Ip= ip,
                NumIids= numIids,
                Platform= platform
            };
            return _aliApiService.GetAliGoodDetail(req);
        }

    }
}