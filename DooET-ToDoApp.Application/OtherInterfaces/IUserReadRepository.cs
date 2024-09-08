using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.OtherInterfaces
{
    public interface IUserReadRepository
    {
        Task<bool> CheckUserDoesNotExistByEmail(string email);
    }
}
