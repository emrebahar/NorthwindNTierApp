using NTierApp.BLL.Repositories.Abstract;
using NTierApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Repositories.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        DataContext db = DbInstance.Instance;
        public int Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
            return 1;

        }

        public void Delete(T entity)
        {
            try
            {
                db.Set(typeof(T)).Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> GetAllList()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update()
        {
            db.SaveChanges();
        }
    }
}
