using MediatR;
using MovieApp.DTOs.Users;

namespace MovieApp.Applications.Commands.Users
{
    public class LoginCommand : IRequest<RegisterUserResponseDTO>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
