using DooET_ToDoApp.Application.Features.User.Request;
using DooET_ToDoApp.Application.OtherInterfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Application.Validations
{
    public class UserCreationRequestValidator : AbstractValidator<UserCreationRequest>
    {
        private readonly IUserReadRepository _userRepository;
        public UserCreationRequestValidator(IUserReadRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(t => t.FirstName).NotEmpty().WithMessage("Username can not be empty")
                .NotNull().MaximumLength(250);
            RuleFor(t => t.LastName).NotEmpty().WithMessage("Username can not be empty")
                .NotNull().MaximumLength(250);
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

            RuleFor(t => t.Password)
            .NotEmpty().WithMessage("Password cannot be empty")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
            .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter")
            .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter")
            .Matches("[0-9]").WithMessage("Password must contain at least one number")
            .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character");


        }

        private bool IsEmailUnique(string email)
        {
            try
            {
                var doesNotExist = _userRepository.CheckUserDoesNotExistByEmail(email);
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
