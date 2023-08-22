using MediatR;
using MovieApp.DTOs.Users;

namespace MovieApp.Applications.Commands.Users
{
    public class RegisterUserCommand : IRequest<RegisterUserResponseDTO>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
