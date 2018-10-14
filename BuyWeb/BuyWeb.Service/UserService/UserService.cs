using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyWeb.Dao.Dao;
using BuyWeb.Dao.Entity;
using BuyWeb.Dao.IDao;
using BuyWeb.Service.Common;
using static BuyWeb.Service.Common.Constant;
using static BuyWeb.Service.Common.LogHelp;

namespace BuyWeb.Service.UserService
{
    public class UserService : IUserService
    {
        private IUserDao _userDao;
        public UserService()
        {
            _userDao = new UserDao();
        }
        public ApiResult<bool> DeleteUser(UserEntity userEntity)
        {
            ApiResult<bool> apiResult = new ApiResult<bool>();
            try
            {
                apiResult.IsSuccess = _userDao.DeleteUser(userEntity) > 0;
                if (!apiResult.IsSuccess)
                {
                    apiResult.Message = Error_2;
                }
            }
            catch (Exception e)
            {
                apiResult.IsSuccess = false;
                apiResult.Message = Error_1;
                WriteExceptionLog("删除用户", e.Message);
            }
            return apiResult;
        }

        public ApiResult<List<UserEntity>> GetUserList()
        {
            ApiResult<List<UserEntity>> apiResult = new ApiResult<List<UserEntity>>();
            try
            {
                apiResult.Data = _userDao.GetUserList();
                apiResult.IsSuccess = true;
            }
            catch (Exception e)
            {
                apiResult.IsSuccess = false;
                apiResult.Message = Error_1;
                WriteExceptionLog("获取所有用户", e.Message);
            }
            return apiResult;
        }

        public ApiResult<bool> InsertUser(UserEntity userEntity)
        {
            ApiResult<bool> apiResult = new ApiResult<bool>();
            try
            {
                apiResult.IsSuccess = _userDao.InsertUser(userEntity) > 0;
                if (!apiResult.IsSuccess)
                {
                    apiResult.Message = Error_2;
                }
            }
            catch (Exception e)
            {
                apiResult.IsSuccess = false;
                apiResult.Message = Error_1;
                WriteExceptionLog("新增用户", e.Message);

            }

            return apiResult;
        }

        public ApiResult<UserEntity> SearchUser(UserEntity userEntity, int type)
        {
            ApiResult<UserEntity> apiResult = new ApiResult<UserEntity>();
            try
            {
                apiResult.Data = _userDao.SearchUser(userEntity, type);
                apiResult.IsSuccess = true;
                if (apiResult.Data == null)
                {
                    apiResult.IsSuccess = false;
                    apiResult.Message = "未获取到信息";
                }

            }
            catch (Exception e)
            {
                apiResult.IsSuccess = false;
                apiResult.Message = Error_1;
                WriteExceptionLog("查询用户", e.Message);
            }
            return apiResult;
        }

        public ApiResult<bool> UpdateUser(UserEntity userEntity)
        {
            ApiResult<bool> apiResult = new ApiResult<bool>();
            try
            {
                apiResult.IsSuccess = _userDao.UpdateUser(userEntity) > 0;
                if (!apiResult.IsSuccess)
                {
                    apiResult.Message = Error_2;
                }
            }
            catch (Exception e)
            {
                apiResult.IsSuccess = false;
                apiResult.Message = Error_1;
                WriteExceptionLog("更新用户信息", e.Message);
            }
            return apiResult;
        }
    }
}
