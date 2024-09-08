using DooET_TodoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Persistence
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options)
            : base(options) { }
        
        DbSet<Todo> Todos { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Category> Categories { get; set; }    
    }
}
