using AutoMapper;
using MovieApp.Data.Entities;
using MovieApp.DTOs.Movies;
using MovieApp.DTOs.Users;

namespace MovieApp.Applications.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<User, UserDTO>();

            CreateMap<Movie, MovieDTO>();
        }
    }
}
