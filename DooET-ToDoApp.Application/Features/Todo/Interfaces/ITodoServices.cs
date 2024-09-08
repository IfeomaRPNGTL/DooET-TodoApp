using DooET_ToDoApp.Application.Features.Task.DTO.Response;
using DooET_ToDoApp.Application.Features.User.DTO.Request;
using DooET_ToDoApp.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.Features.User.Interfaces
{
    public interface ITodoService
    {
        Task<BaseResponse<TodoCreationResponse>> CreateTodo(TodoCreationRequest dto);
        Task<BaseResponse<TodoUpdateResponse>> UpdateTodo(TodoUpdateRequest dto);
    }
}
