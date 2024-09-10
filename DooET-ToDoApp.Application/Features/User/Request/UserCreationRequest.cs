using DooET_TodoApp.Domain.Entities;
using DooET_ToDoApp.Application.Features.User.DTO.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateTodo = DooET_TodoApp.Domain.Entities.User;



namespace DooET_ToDoApp.Application.Features.User.Request
{
    public class UserCreationRequest
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Todo> Tasks { get; set; }

        //create User
        //public static DooET_TodoApp.Domain.Entities.User Copy(UserCreationRequest request)
        //{
        //    if (request == null) throw new ArgumentNullException(nameof(request));
        //    var user = new DooET_TodoApp.Domain.Entities.User
        //    {
        //        Email = request.Email,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //        Password = request.Password
        //    };
        //    return user;
        //}

       
    }

    
}
