using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Consumer.JDApi.JDApiDto
{
    public class JDRequestBase
    {
        /// <summary>
        /// 是
        /// API接口名称
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// 是
        /// 采用OAuth授权方式为必填参数
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// 是
        /// 应用的app_key
        /// </summary>
        public string app_key { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 是
        /// 时间戳，格式为yyyy-MM-dd HH:mm:ss，
        /// 例如：2011-06-16 13:23:30。京东API服务端允许客户端请求时间误差为6分钟
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 暂时只支持json
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// API协议版本，可选值:2.0
        /// </summary>
        public string v { get; set; }

    }
  
}
