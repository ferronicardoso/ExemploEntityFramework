using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.DAL.Repositories.Base
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        List<T> GetList();
        T Add(T entity);
        T Delete(T entity);
        T GetById(long id);
        void Update (long id, T newEntity);
        bool Exists(int id);
        bool Exists(Expression<Func<T, bool>> expression);
    }
}
