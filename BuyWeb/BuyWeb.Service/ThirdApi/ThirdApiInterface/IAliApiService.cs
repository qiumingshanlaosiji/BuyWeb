using BuyWeb.Consumer.AliApi.AliApiDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api.Response;

namespace BuyWeb.Service.ThirdApi
{
    public interface IAliApiService
    {
        ApiResult<AliGoodSerarchRes> GetAliGoodsList(AliGoodSerarchReq req);

        ApiResult<AliGoodDetailRes> GetAliGoodDetail(AliGoodDetailReq req);
    }
}
