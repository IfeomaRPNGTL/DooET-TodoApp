using DooET_TodoApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = DooET_TodoApp.Domain.Enum.TaskStatus;

namespace DooET_TodoApp.Domain.Entities
{
    public class Todo : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set;}
        public TaskStatus Status { get; set; }
        public PriorityLevel Priority { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
