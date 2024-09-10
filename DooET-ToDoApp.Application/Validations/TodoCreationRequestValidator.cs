using DooET_ToDoApp.Application.Features.User.DTO.Request;
using DooET_ToDoApp.Application.OtherInterfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.Validations
{
    public class TodoCreationRequestValidator : AbstractValidator<TodoCreationRequest>
    {
        private readonly IUserReadRepository _todoRepository;
        public TodoCreationRequestValidator(IUserReadRepository todoRepository)
        {
            _todoRepository = todoRepository;
            RuleFor(t => t.TaskName).NotEmpty().WithMessage("Task name cannot be empty")
                .NotNull()
                .MaximumLength(250);

            RuleFor(t => t.Description).NotEmpty().WithMessage("Description cannot be empty")
                .NotNull()
                .MaximumLength(250);

            RuleFor(t => t.Email)
              .EmailAddress().WithMessage("Provide a valid email address.")
              .NotNull()
              .MaximumLength(250);

            RuleFor(t => t)
                .Must(t =>
                {
                    var result = IsEmailUnique(t.Email);
                    return result;
                }).WithMessage("Email is not unique");
        }

        private bool IsEmailUnique(string email)
        {
            try
            {
                var doesNotExist = _todoRepository.CheckUserDoesNotExistByEmail(email);
                if (doesNotExist.Result) return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
