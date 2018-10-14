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
    public class UserDao : IUserDao
    {

        private static string sqlStr = ConfigurationManager.AppSettings["SqlStr"]?.ToString();
        private SqlConnection coon = new SqlConnection(sqlStr);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public int DeleteUser(UserEntity userEntity)
        {
            return coon.Execute("Update  VipUser Set IsDeleted=1,ModifiedTime=GETDATE() where UserName=@UserName", userEntity);
        }

        /// <summary>
        /// 获取用户集合
        /// </summary>
        /// <returns></returns>
        public List<UserEntity> GetUserList()
        {
            return coon.Query<UserEntity>("select *from VipUser where IsDeleted=0").ToList();

        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public int InsertUser(UserEntity userEntity)
        {
            return coon.Execute("insert into VipUser(UserName,Phone,Email,PassWord) values(@UserName,@Phone,@Email,@PassWord)", userEntity);
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="type">
        /// 0:根据用户名查询
        /// 1:根据用户名和密码进行查询
        /// 2.根据电话号码进行查询
        /// 3:根据邮箱进行查询
        /// 4:根据ID进行查询
        /// </param>
        /// <returns></returns>
        public UserEntity SearchUser(UserEntity userEntity, int type)
        {
            string sql = "select *from VipUser where IsDeleted=0 ";
            switch(type)
            {
                case 0:
                    sql += $"AND UserName='{userEntity.UserName}'";
                    break;
                case 1:
                    sql += $"AND UserName='{userEntity.UserName}' AND PassWord='{userEntity.PassWord}'";
                    break;
                case 2:
                    sql += $"AND Phone='{userEntity.Phone}'";
                    break;
                case 3:
                    sql += $"AND Email='{userEntity.Email}'";
                    break;
                case 4:
                    sql += $"AND Id='{userEntity.Id}'";
                    break;
                default:
                    sql += $"AND UserName='{userEntity.UserName}'";
                    break;

            }
            return coon.Query<UserEntity>(sql).FirstOrDefault();
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public int UpdateUser(UserEntity userEntity)
        {
            return coon.Execute("Update  VipUser Set ModifiedTime=GETDATE(),Phone=@Phone,Email=@Email,PassWord=@PassWord  where UserName=@UserName", userEntity);
        }
    }
}
