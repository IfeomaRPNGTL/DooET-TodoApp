using DooET_ToDoApp.Application.OtherInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Persistence
{
    public class UserReadRepository : IUserReadRepository
    {
        public Task<bool> CheckUserDoesNotExistByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
