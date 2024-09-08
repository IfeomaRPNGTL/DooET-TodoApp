using DooET_TodoApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.Features.Task.DTO.Response
{
    public class TodoCreationResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public PriorityLevel Priority { get; set; }
    }
}
