using BuyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BuyWeb.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        private ITest _test;
        public TestController()
        {
            _test =new Test();
        }
       
        public int Index(int id)
        {
            return _test.TestMethod(id);
        }

        [HttpGet]
        [Route("index")]
        public string IndexTest()
        {
            return "测试";
        }

    }
}