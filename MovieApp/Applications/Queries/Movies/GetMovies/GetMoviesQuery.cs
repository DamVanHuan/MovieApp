using MediatR;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Movies;

namespace MovieApp.Applications.Queries.Movies
{
    public class GetMoviesQuery : IRequest<ListResult<MovieDTO>>
    {
        public int Offset { get; set; } = 0;
        public int Limit { get; set; } = 10;
    }
}
