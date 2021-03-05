using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DotinBankProject.Domain.Repositories.Base;

namespace DotinBankProject.Data.Data.Services.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DotinBankContext _context;

        public Repository(DotinBankContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            

        }

        public object Add(object entity)
        {
           return _context.Set<object>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public void AddSaveChanges(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
