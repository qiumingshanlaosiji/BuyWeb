using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyWeb.Consumer.AliApi;
using BuyWeb.Consumer.AliApi.AliApiDto;
using Top.Api.Request;
using Top.Api.Response;

namespace BuyWeb.Service.ThirdApi
{
    public class AliApiService : IAliApiService
    {
        private AliApi _aliApi;
        public AliApiService()
        {
            _aliApi = new AliApi();
        }

        public ApiResult<AliGoodDetailRes> GetAliGoodDetail(AliGoodDetailReq req)
        {
            ApiResult<AliGoodDetailRes> apiResult = new ApiResult<AliGoodDetailRes>();
            try
            {
                apiResult.Data = _aliApi.GetGoodDetail(req);
                apiResult.IsSuccess = true;
            }
            catch(Exception e)
            {
                apiResult.Message = e.Message;
            }
            return apiResult;
        }

        public ApiResult<AliGoodSerarchRes> GetAliGoodsList(AliGoodSerarchReq req)
        {
            ApiResult<AliGoodSerarchRes> apiResult = new ApiResult<AliGoodSerarchRes>();
            try
            {
                apiResult.Data = _aliApi.GetAliGoodsList(req);
                apiResult.IsSuccess = true;
            }
            catch (Exception e)
            {
                apiResult.Message = e.Message;
            }
            return apiResult;
        }
    }
}
