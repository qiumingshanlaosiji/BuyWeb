using BuyWeb.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Service
{
    public class Test : ITest
    {
        private ITestDao testDao;
        public Test()
        {
            testDao = new TestDao();
        }

        public int TestMethod(int num)
        {
            if(num==0)
            {
                var s = testDao.Insert(new TestDaoEntity() { Name="1"});
            }
            if (num == 1)
            {
                var s = testDao.Insert(new List<TestDaoEntity>() { new TestDaoEntity() { Name = "2" } , new TestDaoEntity() { Name = "3" } });
            }
            if (num == 2)
            {
                var s = testDao.Update(new TestDaoEntity() { Id=1,Name="12"});
            }
            if (num == 3)
            {
                var s = testDao.Delete(new TestDaoEntity() { Id = 1, Name = "1" });
            }
            if (num == 4)
            {
             var s=   testDao.GetAll();
            }
            if (num == 5)
            {
                var s = testDao.GetById(2);
            }
            
            return 1;
        }
    }
}
