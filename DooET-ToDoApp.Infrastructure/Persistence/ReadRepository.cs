using Microsoft.EntityFrameworkCore;
using DooET_ToDoApp.Application.OtherInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Persistence
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly AppDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public ReadRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<List<T>> GetAllAsync()
        {
           List<T> list = new List<T>();
           return list;
        }

        public Task<T> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
    
}
