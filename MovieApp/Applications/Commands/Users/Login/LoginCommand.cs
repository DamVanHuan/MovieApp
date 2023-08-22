using MediatR;
using MovieApp.DTOs.Users;

namespace MovieApp.Applications.Commands.Users
{
    public class LoginCommand : IRequest<RegisterUserResponseDTO>
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
