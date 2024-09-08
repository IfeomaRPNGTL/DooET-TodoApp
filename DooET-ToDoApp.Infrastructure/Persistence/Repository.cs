using DooET_ToDoApp.Application.OtherInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Persistence
{
    public class Repository<T> : IUnitOfWork, IRepository<T> where T : class
    {
        private readonly AppDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDBContext dbcontext)
        {
            _dbContext = dbcontext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                var result = await _dbSet.AddAsync(entity);
                var save = await SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
             _dbSet.Attach(entity);
             _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
