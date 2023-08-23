using FluentValidation;

namespace MovieApp.Applications.Commands.Users
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .When(x => string.IsNullOrEmpty(x.Email))
                .WithErrorCode("UsernameEmailRequired")
                .WithMessage("Username/Email is required");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithErrorCode("PasswordIsRequired")
                .WithMessage("Password is required");
        }
    }
}
