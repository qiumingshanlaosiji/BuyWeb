using BuyWeb.Dao.Dao;
using BuyWeb.Dao.Entity;
using BuyWeb.Dao.IDao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BuyWeb.Service.Common
{
    public class LogHelp
    {
      

        /// <summary>
        /// 异常日志
        /// </summary>
        /// <param name="entity"></param>
        public static void WriteExceptionLog(string method, string message)
        {
            LogDao logDao = new LogDao();
            ExceptionLogEntity entity = new ExceptionLogEntity()
            {
                ExceptionMessage = message,
                ExceptionModule = method
            };
            logDao.InsertExceptionLog(entity);
        }

        public static void WriteBusinessListLog(List<BusinessLogEntity> entity)
        {
            LogDao logDao = new LogDao();

            logDao.InsertBusinessLog(entity);

        }

        public static void WriteBusinessLog(string method, string messageOne, string messageTwo)
        {
            LogDao logDao = new LogDao();

            BusinessLogEntity entity = new BusinessLogEntity()
            {
                LogType = method,
                MessageOne = messageOne,
                MessageTwo = messageTwo
            };
            logDao.InsertBusinessLog(entity);

        }
    }
}