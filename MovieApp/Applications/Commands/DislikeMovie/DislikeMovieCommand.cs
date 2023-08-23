using MediatR;
using MovieApp.DTOs.Commons;

namespace MovieApp.Applications.Commands
{
    public class DislikeMovieCommand : IRequest<ResponseBase>
    {
        public DislikeMovieCommand(int movieId, int userId)
        {
            MovieId = movieId;
            UserId = userId;
        }

        public int MovieId { get; set; }
        public int UserId { get; private set; }
    }
}
