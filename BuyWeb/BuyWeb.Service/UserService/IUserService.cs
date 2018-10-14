using BuyWeb.Dao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Service.UserService
{
    public interface IUserService
    {
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        ApiResult<bool> InsertUser(UserEntity userEntity);

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        ApiResult<bool> UpdateUser(UserEntity userEntity);

        /// <summary>
        /// 获取用户集合
        /// </summary>
        /// <returns></returns>
        ApiResult<List<UserEntity>> GetUserList();

        /// <summary>
        /// 根据条件查询用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        ApiResult<UserEntity> SearchUser(UserEntity userEntity, int type);

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        ApiResult<bool> DeleteUser(UserEntity userEntity);
    }
}
