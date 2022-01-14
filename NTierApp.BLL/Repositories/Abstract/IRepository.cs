using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        int Add(T entity);
        void Update();
        void Delete(T entity);
        List<T> GetAllList();
        T GetById(int id);
    }
}
