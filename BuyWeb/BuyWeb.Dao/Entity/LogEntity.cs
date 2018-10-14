using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Dao.Entity
{
    public class ExceptionLogEntity
    {
        /// <summary>
        /// 异常模块
        /// </summary>
        public string ExceptionModule { get; set; }

        /// <summary>
        /// 异常报文
        /// </summary>
        public string ExceptionMessage
        {
            get
            {
                if (_ExceptionMessage.Length > 500)
                {
                    _ExceptionMessage = _ExceptionMessage.Substring(0, 499);
                }

                return _ExceptionMessage;
            }
            set { _ExceptionMessage = value; }
        }

        private string _ExceptionMessage;
    }

    public class BusinessLogEntity
    {

        /// <summary>
        /// 日志类型
        /// </summary>
        public string LogType { get; set; }

        /// <summary>
        /// 消息1
        /// </summary>
        public string MessageOne
        {
            get
            {
                if (_MessageOne.Length > 500)
                {
                    _MessageOne = _MessageOne.Substring(0, 999);
                }
                return _MessageOne;
            }
            set { _MessageOne = value; }
        }

        private string _MessageOne;

        /// <summary>
        /// 消息2
        /// </summary>
        public string MessageTwo
        {
            get
            {

                if (_MessageTwo.Length > 1000)
                {
                    _MessageTwo = _MessageTwo.Substring(0, 999);
                }
                return _MessageTwo;
            }
            set { _MessageTwo = value; }
        }

        private string _MessageTwo;

    }
}
