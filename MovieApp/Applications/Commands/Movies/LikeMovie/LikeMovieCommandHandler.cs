using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Data.Entities;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Exceptions;

namespace MovieApp.Applications.Commands.Movies
{
    public class LikeMovieCommandHandler : IRequestHandler<LikeMovieCommand, ResponseBase>
    {
        private readonly MovieContext _context;

        public LikeMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<ResponseBase> Handle(LikeMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = await _context
                .Movies
                .Include(m => m.MovieReactions.Where(ml => ml.UserId == request.UserId))
                .FirstOrDefaultAsync(m => m.Id == request.MovieId);

            if (movie == null)
            {
                throw new BadRequestException("NotFound", "Movie cannot found");
            }

            // If user liked movie then unlike, otherwise like.
            bool liked = false;
            if (movie.MovieReactions.Any())
            {
                var movieLike = movie.MovieReactions.ElementAt(0);
                liked = movieLike.Liked;
                if (liked)
                {
                    movieLike.Liked = false;
                    movie.Like--;
                }
                else
                {
                    movieLike.Liked = true;
                    movie.Like++;
                }
            }
            else
            {
                var movieLike = new MovieReaction
                {
                    MovieId = movie.Id,
                    UserId = request.UserId,
                    Liked = true
                };
                movie.MovieReactions.Add(movieLike);
                movie.Like++;
            }

            await _context.SaveChangesAsync();

            var message = (liked ? "Unlike" : "Like") + " movie successfully";
            return new ResponseBase("Success", message);
        }
    }
}
