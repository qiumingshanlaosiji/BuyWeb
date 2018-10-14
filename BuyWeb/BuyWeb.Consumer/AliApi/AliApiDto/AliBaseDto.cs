using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Consumer.AliApi.AliApiDto
{
    public class AliRequestBase
    {
        /// <summary>
        /// 是
        /// API接口名称
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// 是
        /// TOP分配给应用的AppKey
        /// </summary>
        public string app_key { get; set; } = "24967649";

        /// <summary>
        /// 否
        /// 被调用的目标AppKey，仅当被调用的API为第三方ISV提供时有效
        /// </summary>
        public string target_app_key { get; set; }

        /// <summary>
        /// 是
        /// 签名的摘要算法，可选值为：hmac，md5
        /// </summary>
        public string sign_method { get; set; } = "md5";

        /// <summary>
        /// 是
        /// API输入参数签名结果
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 否
        /// 用户登录授权成功后，TOP颁发给应用的授权信息，
        /// 详细介绍请点击这里。当此API的标签上注明：“需要授权”，
        /// 则此参数必传；“不需要授权”，则此参数不需要传；“可选授权”，
        /// 则此参数为可选
        /// </summary>
        public string session { get; set; }

        /// <summary>
        /// 是
        /// 	时间戳，格式为yyyy-MM-dd HH:mm:ss，时区为GMT+8，
        /// 	例如：2015-01-01 12:00:00。
        /// 	淘宝API服务端允许客户端请求最大时间误差为10分钟
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 否
        /// 响应格式。默认为xml格式，可选值：xml，json。
        /// </summary>
        public string format { get; set; } = "json";

        /// <summary>
        /// 是
        /// API协议版本，可选值：2.0
        /// </summary>
        public string v { get; set; } = "2.0";

        /// <summary>
        /// 否
        /// 合作伙伴身份标识
        /// </summary>
        public string partner_id { get; set; }

        /// <summary>
        /// 否
        /// 是否采用精简JSON返回格式，
        /// 仅当format=json时有效，默认值为：false
        /// </summary>
        public bool simplify { get; set; }

    }

    public class AliResponseBase
    {

        /// <summary>
        /// 错误码
        /// </summary>

        public string ErrCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>

        public string ErrMsg { get; set; }

        /// <summary>
        /// 子错误码
        /// </summary>

        public string SubErrCode { get; set; }

        /// <summary>
        /// 子错误信息
        /// </summary>

        public string SubErrMsg { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get; set;
        }

    }
}
