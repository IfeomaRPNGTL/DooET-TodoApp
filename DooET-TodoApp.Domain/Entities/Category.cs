using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_TodoApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Todo> Tasks { get; set; }
    }
}
