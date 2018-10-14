using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Consumer.JDApi
{


    public class JDApi
    {
        private static string JdUrl => ConfigurationManager.AppSettings["JdUrl"]?.ToString();


    }
}
