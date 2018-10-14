using BuyWeb.Dao.Entity;
using BuyWeb.Service;
using BuyWeb.Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BuyWeb.Controllers
{

    [RoutePrefix("api/user")]
    public class UserApiController : ApiController
    {
        private IUserService _userService;
        public UserApiController()
        {
            _userService = new UserService();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        [HttpPost, Route("insert")]
        public ApiResult<bool> InsertUser(UserEntity userEntity)
        {
            return _userService.InsertUser(userEntity);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        [HttpPost, Route("update")]

      public  ApiResult<bool> UpdateUser(UserEntity userEntity)
        {
            return _userService.UpdateUser(userEntity);

        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost, Route("search")]

        public ApiResult<UserEntity> SearchUser(UserEntity userEntity, int type)
        {
            return _userService.SearchUser(userEntity, type);
        }

    }
}