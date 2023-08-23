using MediatR;
using MovieApp.DTOs.Commons;

namespace MovieApp.Applications.Commands.Movies
{
    public class LikeMovieCommand : IRequest<ResponseBase>
    {
        public LikeMovieCommand(int movieId, int userId)
        {
            MovieId = movieId;
            UserId = userId;
        }

        public int MovieId { get; set; }
        public int UserId { get; private set; }
    }
}
