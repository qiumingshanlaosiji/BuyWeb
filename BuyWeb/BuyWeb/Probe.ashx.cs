using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyWeb
{
    /// <summary>
    /// Probe 的摘要说明
    /// </summary>
    public class Probe : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Ok");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}