using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Dao
{
    public class TestDao : ITestDao
    {
        private static  string sqlStr = ConfigurationManager.AppSettings["SqlStr"]?.ToString();
        private  SqlConnection coon = new SqlConnection(sqlStr);

        public int Delete(TestDaoEntity entity)
        {
            return coon.Execute("delete Test where Id=@Id", entity);

        }

        public List<TestDaoEntity> GetAll()
        {

            var a = new { c = 1 };
            dynamic b = new { d = 1 };
            b.d = 2;
            return coon.Query<TestDaoEntity>("select *from Test").ToList();
        }

        public TestDaoEntity GetById(int id)
        {
            return coon.Query<TestDaoEntity>($"select *from Test where Id={id}").FirstOrDefault();

        }
        public int Insert(TestDaoEntity entity)
        {
            return coon.Execute("insert into Test(Name) values(@Name)", entity);
        }
        public int Insert(List<TestDaoEntity> entity)
        {
            return coon.Execute("insert into Test(Name) values(@Name)", entity);
        }
        public int Update(TestDaoEntity entity)
        {
            return coon.Execute("update  Test set Name=@Name  where Id=@Id", entity);

        }
    }
}
