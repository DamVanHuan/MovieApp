using AutoMapper;
using MediatR;
using MovieApp.Commons;
using MovieApp.Data;
using MovieApp.Data.Entities;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Users;

namespace MovieApp.Applications.Commands.Users
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisterUserResponseDTO>
    {
        private readonly MovieContext _movieContext;
        private readonly IMapper _mapper;
        private readonly JWT _jwt;

        public RegisterUserCommandHandler(MovieContext movieContext, IMapper mapper, JWT jwt)
        {
            _movieContext = movieContext;
            _mapper = mapper;
            _jwt = jwt;
        }

        public async Task<RegisterUserResponseDTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Email = request.Email,
                Username = request.UserName,
            };
            user.Password = LoginHelper.EncryptPassword(request.Password, request.UserName ?? request.Email);
            await _movieContext.AddAsync(user);
            await _movieContext.SaveChangesAsync();

            var userDto = _mapper.Map<UserDTO>(user);
            return new RegisterUserResponseDTO
            {
                Token = LoginHelper.GenerateToken(user, _jwt),
                User = userDto
            };
        }
    }
}
