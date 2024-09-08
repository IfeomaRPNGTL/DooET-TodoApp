using DooET_ToDoApp.Application.Features.User.DTO.Request;
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
        public TodoCreationRequestValidator()
        {
            RuleFor(t => t.TaskName).NotEmpty().WithMessage("Task name cannot be empty")
                .NotNull()
                .MaximumLength(250);
            RuleFor(t => t.Description).NotEmpty().WithMessage("Description cannot be empty")
                .NotNull()
                .MaximumLength(250);
        }
    }
}
