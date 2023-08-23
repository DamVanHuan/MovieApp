using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Commons;
using MovieApp.Data;
using MovieApp.Data.Entities;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Exceptions;
using MovieApp.DTOs.Users;

namespace MovieApp.Applications.Commands.Users
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, RegisterUserResponseDTO>
    {
        private readonly MovieContext _movieContext;
        private readonly IMapper _mapper;
        private readonly JWT _jwt;

        public LoginCommandHandler(MovieContext movieContext, IMapper mapper, JWT jwt)
        {
            _movieContext = movieContext;
            _mapper = mapper;
            _jwt = jwt;
        }

        public async Task<RegisterUserResponseDTO> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User user = await _movieContext
                .Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == request.Username || u.Email == request.Username);

            if (user != null)
            {
                var encryptedPassword = LoginHelper.EncryptPassword(request.Password, user.Uid.ToString());
                if (user.Password == encryptedPassword)
                {
                    var token = LoginHelper.GenerateToken(user, _jwt);
                    return new RegisterUserResponseDTO
                    {
                        User = _mapper.Map<UserDTO>(user),
                        Token = token
                    };
                }

            }

            throw new BadRequestException("LoginFailed", "Username/Email or password incorrect");
        }
    }
}
