using DooET_TodoApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateTodo = DooET_TodoApp.Domain.Entities.Todo;

namespace DooET_ToDoApp.Application.Features.User.DTO.Request
{
    public class TodoCreationRequest
    {
        public string UserName { get; set; }
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        public string Email { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public PriorityLevel Priority { get; set; }

        // create todo
        public static DooET_TodoApp.Domain.Entities.Todo Copy(TodoCreationRequest dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            var userTodo = new DooET_TodoApp.Domain.Entities.Todo
            {
                Email = dto.Email,
                Name = dto.TaskName,
                Description = dto.Description,
                Priority = dto.Priority,
                DueDate = dto.DueDate,
            };
            return userTodo;    
        }

        public static CreateTodo Copy(DooET_TodoApp.Domain.Entities.Todo createtodo, TodoCreationRequest dto)
        {
            if(createtodo == null) throw new ArgumentNullException(nameof(createtodo));
            var userTodo = new CreateTodo
            {
                Email = createtodo.Email,
                Description = createtodo.Description,
                Priority = createtodo.Priority,
                Name = createtodo.Name,
                DueDate = createtodo.DueDate,
                Category = createtodo.Category,
            };
            return userTodo;
        }


    }
}
