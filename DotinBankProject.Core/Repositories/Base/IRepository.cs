using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DotinBankProject.Domain.Repositories.Base
{
    public interface IRepository<TEntity> where  TEntity:class
    {

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Save();
        void AddSaveChanges(TEntity entity);
        object Add(object entity);
    }
}
