using MediatR;
using MovieApp.Data.Entities;
using MovieApp.Data;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Applications.Commands.Movies
{
    public class DislikeMovieCommandHandler : IRequestHandler<DislikeMovieCommand, ResponseBase>
    {
        private readonly MovieContext _context;

        public DislikeMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<ResponseBase> Handle(DislikeMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = await _context
                .Movies
                .Include(m => m.MovieReactions.Where(ml => ml.UserId == request.UserId))
                .FirstOrDefaultAsync(m => m.Id == request.MovieId);

            if (movie == null)
            {
                throw new BadRequestException("NotFound", "Movie cannot found");
            }

            // If user disliked movie then undislike, otherwise dislike.
            bool disliked = false;
            if (movie.MovieReactions.Any())
            {
                var movieReaction = movie.MovieReactions.ElementAt(0);
                disliked = movieReaction.Disliked;
                if (disliked)
                {
                    movieReaction.Disliked = false;
                    movie.Dislike--;
                }
                else
                {
                    movieReaction.Disliked = true;
                    movie.Dislike++;
                }
            }
            else
            {
                var movieLike = new MovieReaction
                {
                    MovieId = movie.Id,
                    UserId = request.UserId,
                    Disliked = true
                };
                movie.MovieReactions.Add(movieLike);
                movie.Dislike++;
            }

            await _context.SaveChangesAsync();

            var message = (disliked ? "Undislike" : "Dislike") + " movie successfully";
            return new ResponseBase("Success", message);
        }
    }
}
