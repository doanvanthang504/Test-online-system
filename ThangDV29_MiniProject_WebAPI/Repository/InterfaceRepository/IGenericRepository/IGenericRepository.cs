using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> FindAllAsync();
        Task<TEntity> FindByIdAsync(Guid id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity,bool>> predicate);
    }
}
