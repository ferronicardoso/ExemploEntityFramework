using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.DAL.Repositories.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationContext _context;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(ApplicationContext model)
        {
            _context = model;
            _dbset = _context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbset.AsQueryable();
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbset.Where(expression);
        }

        public virtual List<T> GetList()
        {
            return _dbset.AsQueryable().ToList();
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual T GetById(long id)
        {
            return _dbset.Find(id);
        }
        
        public virtual void Update(long id, T newEntity)
        {
            var originalEntity = _dbset.Find(id);
            _context.Entry(originalEntity).CurrentValues.SetValues(newEntity);
        }

        public virtual bool Exists(int id)
        {
            return this.GetById(id) != null;
        }

        public virtual bool Exists(long id)
        {
            return this.GetById(id) != null;
        }

        public virtual bool Exists(Expression<Func<T, bool>> expression)
        {
            return _dbset.Any(expression);
        }

        public int SaveChanges()
        {
            return this._context.SaveChanges();
        }
    }
}
