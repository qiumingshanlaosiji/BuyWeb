using BuyWeb.Dao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Dao.IDao
{
    public interface IUserDao
    {
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        int InsertUser(UserEntity userEntity);

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        int UpdateUser(UserEntity userEntity);

        /// <summary>
        /// 获取用户集合
        /// </summary>
        /// <returns></returns>
        List<UserEntity> GetUserList();

        /// <summary>
        /// 根据条件查询用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        UserEntity SearchUser(UserEntity userEntity,int type);

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        int DeleteUser(UserEntity userEntity);


    }
}
