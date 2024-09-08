using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.Helpers
{
    public class BaseResponse<T>
    {
        public bool Status { get; set; }
        public string? Message { get; set; }
        public T Data { get; set; }
    }
}
