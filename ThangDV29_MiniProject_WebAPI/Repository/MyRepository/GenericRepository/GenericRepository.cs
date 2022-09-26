using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo;

namespace ThangDV29_MiniProject_WebAPI.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly IApplicationDBContext _dbContext;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(IApplicationDBContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }


        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity,bool>> predicate)
        {
            var listItem = await _dbSet.Where(predicate).ToListAsync();
            return listItem;
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            var listItem = await _dbSet.ToListAsync();
            return listItem;
        }

        public async Task<TEntity> FindByIdAsync(Guid id)
        {
            var find = await _dbSet.FindAsync(id);
            return find;
        }

        public void Insert(TEntity entity)
        {
            if (entity != null)
            {
                 _dbSet.Add(entity);
            }
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
