using DooET_TodoApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.Features.User.DTO.Request
{
    public class TodoUpdateRequest
    {
        public string? Name { get; set; }
        public PriorityLevel Priority { get; set; }

    }
}
