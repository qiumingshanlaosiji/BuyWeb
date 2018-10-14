using BuyWeb.Dao.Entity;
using BuyWeb.Dao.IDao;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Dao.Dao
{
    public class LogDao : ILogDao
    {
        private static string sqlStr = ConfigurationManager.AppSettings["SqlStr"]?.ToString();
        private SqlConnection coon = new SqlConnection(sqlStr);

        /// <summary>
        /// 业务日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int InsertBusinessLog(BusinessLogEntity entity)
        {
            try
            {
                return coon.Execute("INSERT INTO BusinessLog(LogType, MessageOne,MessageTwo) " +
                "VALUES(@LogType, @MessageOne,@MessageTwo)", entity);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /// <summary>
        /// 业务日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int InsertBusinessLog(List<BusinessLogEntity> entity)
        {
            try
            {
                return coon.Execute("INSERT INTO BusinessLog(LogType, MessageOne,MessageTwo) " +
                "VALUES(@LogType, @MessageOne,@MessageTwo)", entity);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /// <summary>
        /// 异常日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int InsertExceptionLog(ExceptionLogEntity entity)
        {
            try
            {
                return coon.Execute("INSERT INTO ExceptionLog(ExceptionModule,ExceptionMessage) " +
                "VALUES(@ExceptionModule,@ExceptionMessage)", entity);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
