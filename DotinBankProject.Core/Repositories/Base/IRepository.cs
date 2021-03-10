using DotinBankProject.Domain.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DotinBankProject.Domain.Repositories.Base
{
    public interface IRepository<TEntity> where  TEntity:Entity
    {
        Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken = default);
        Task<TEntity> GetAsync(int id, CancellationToken cancellationToken = default);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

        //TEntity Get(int id);
        //TEntity Update(TEntity entity);
        //IEnumerable<TEntity> GetAll();
        //IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        //TEntity Add(TEntity entity);
        //void AddRange(IEnumerable<TEntity> entities);
        //void Remove(TEntity entity);
        //void RemoveRange(IEnumerable<TEntity> entities);
        //void Save();
        //void AddSaveChanges(TEntity entity);
        //object Add(object entity);
    }
}
