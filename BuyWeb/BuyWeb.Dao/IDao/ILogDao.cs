using BuyWeb.Dao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Dao.IDao
{
    public interface ILogDao
    {
        /// <summary>
        /// 异常日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int InsertExceptionLog(ExceptionLogEntity entity);

        /// <summary>
        /// 业务日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int InsertBusinessLog(BusinessLogEntity entity);

        /// <summary>
        /// 批量写日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int InsertBusinessLog(List<BusinessLogEntity> entity);


    }
}
