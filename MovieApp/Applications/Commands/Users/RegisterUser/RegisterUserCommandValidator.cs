using FluentValidation;
using MovieApp.Extensions;

namespace MovieApp.Applications.Commands.Users
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty()
                .WithErrorCode("UsernameRequired")
                .WithMessage("Username is required");

            RuleFor(x => x.Username)
                .EmailAddress()
                .When(x => x.Username.IsEmail())
                .WithErrorCode("InvalidEmail")
                .WithMessage("Invalid email");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithErrorCode("PasswordIsRequired")
                .WithMessage("Password is required");
        }
    }
}
