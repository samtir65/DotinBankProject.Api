using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;
using DotinBankProject.Domain.Models.Entities.Base;
using DotinBankProject.Domain.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Services.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DotinBankContext _context;

        public Repository(DotinBankContext context)
        {
            _context = context;
        }

        #region Methods

        public async Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken = default)
        {
            return  _context.Set<TEntity>();

            // IEnumerable<TEntity> GetResult = new List<TEntity>();
            // TaskFactory tf = new TaskFactory();

            //awa tf.StartNew(() => { return _context.Set<TEntity>().AsQueryable(); }); 
            // //await Task.Run();
            // return GetResult;
        }

        public async Task<TEntity> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
           var addResult  =  await _context.Set<TEntity>().AddAsync(entity, cancellationToken);
           await _context.SaveChangesAsync();
           return addResult.Entity; 

        }

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            _context.Entry(entity).State = EntityState.Modified;
           await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
             _context.Set<TEntity>().Remove(entity);
        }

        #endregion



    }


    //public async Task<bool> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    //{
    //    var updated = await _context.UpdateRange(e => e.Id == entity., entity, CancellationToken: cancellationToken);

    //    return updated.IsAcknowledged && updated.ModifiedCount > 0;
    //}
    //    public TEntity Add(TEntity entity)
    //    {
    //        _context.Add(entity).Entity


    //    }

    //    public object Add(object entity)
    //    {
    //       return _context.Set<object>().Add(entity);
    //    }

    //    public void AddRange(IEnumerable<TEntity> entities)
    //    {
    //        _context.Set<TEntity>().AddRange(entities);
    //    }

    //    public void AddSaveChanges(TEntity entity)
    //    {
    //        _context.Set<TEntity>().Add(entity);
    //        _context.SaveChanges();


    //    }

    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
       // return _context.Set<TEntity>().Where(predicate);
    
        
        

    }

    //    public TEntity Get(int id)
    //    {
    //        return _context.Set<TEntity>().Find(id);
    //    }

    //    public IEnumerable<TEntity> GetAll()
    //    {
    //        return _context.Set<TEntity>().ToList();
    //    }

    //    public void Remove(TEntity entity)
    //    {
    //        _context.Set<TEntity>().Remove(entity);
    //    }

    //    public void RemoveRange(IEnumerable<TEntity> entities)
    //    {
    //        _context.Set<TEntity>().RemoveRange(entities);
    //    }

    //    public void Save()
    //    {
    //        _context.SaveChanges();
    //    }

    //    public TEntity Update(TEntity entity)
    //    {
    //        //_context.Set<TEntity>().Update(entity);
    //        _context.Entry(entity).State = EntityState.Modified;
    //       _context.SaveChangesAsync();
    //         return entity;
    //    }


    //}
}
