using MediatR;
using MovieApp.DTOs.Movies;

namespace MovieApp.Applications.Queries.Movies
{
    public class GetMovieByIdQuery : IRequest<MovieDTO>
    {
        public int Id { get; set; }

        public GetMovieByIdQuery(int id)
        {
            Id = id;
        }
    }
}
