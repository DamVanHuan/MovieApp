using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Commons;
using MovieApp.Data;
using MovieApp.Data.Entities;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Exceptions;
using MovieApp.DTOs.Users;
using MovieApp.Extensions;

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

        private async Task<bool> UserExistAsync(string username)
        {
            return await _movieContext
                .Users
                .AsNoTracking()
                .AnyAsync(u => u.Username == username || u.Email == username);
        }

        public async Task<RegisterUserResponseDTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            if (await UserExistAsync(request.Username))
            {
                throw new BadRequestException("UsernameExisted", "Username existed");
            }

            var uid = Guid.NewGuid();
            bool isEmail = request.Username.IsEmail();
            var user = new User
            {
                Email = isEmail ? request.Username : "",
                Username = isEmail ? "" : request.Username,
                Uid = uid
            };
            user.Password = LoginHelper.EncryptPassword(request.Password, uid.ToString());
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
