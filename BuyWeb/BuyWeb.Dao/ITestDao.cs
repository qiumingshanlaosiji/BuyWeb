using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Dao
{
    public interface ITestDao
    {
        List<TestDaoEntity> GetAll();

        TestDaoEntity GetById(int id);

        int Insert(TestDaoEntity entity);

        int Insert(List<TestDaoEntity> entity);

        int Update(TestDaoEntity entity);

        int Delete(TestDaoEntity entity);

    }
}
