using DooET_TodoApp.Domain.Entities;
using DooET_ToDoApp.Application.Features.Task.DTO.Response;
using DooET_ToDoApp.Application.Features.User.DTO.Request;
using DooET_ToDoApp.Application.Features.User.Interfaces;
using DooET_ToDoApp.Application.Features.User.Request;
using DooET_ToDoApp.Application.Helpers;
using DooET_ToDoApp.Application.OtherInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Service
{
    public class TodoService : ITodoService
    {
        private readonly IRepository<Todo> _todoRepository;
        private readonly IReadRepository<Todo> _readTodoRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IReadRepository<User> _readUserRepository;
        public TodoService(IRepository<Todo> todoRepository, IReadRepository<Todo> readTodoRepository, IRepository<User> userRepository, IReadRepository<User> readUserRepository)
        {
            _todoRepository = todoRepository;
            _readTodoRepository = readTodoRepository;
            _userRepository = userRepository;
            _readUserRepository = readUserRepository;
        }
        public async Task<BaseResponse<TodoCreationResponse>> CreateTodo(TodoCreationRequest dto)
        {
          // create user
          var response = new BaseResponse<TodoCreationResponse>();
          var user = TodoCreationRequest.Copy(dto);
          var createuser = await _todoRepository.AddAsync(user);
          if(createuser is null || createuser.Id < 1) {
                response.Message = "Couldn't create user, try again";
                response.Data = new TodoCreationResponse();
                return response;
          }
          

          var userTodo = TodoCreationRequest.Copy(createuser, dto);
          var createUserTodo = _todoRepository.AddAsync(userTodo);
            if (createUserTodo is null || createUserTodo.Id < 1)
            {
                response.Message = "Couldn't create Todo, try again";
                response.Data = new TodoCreationResponse();
                return response;
            }
            return response;
        }

        public Task<BaseResponse<TodoUpdateResponse>> UpdateTodo(TodoUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
