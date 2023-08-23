using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Applications.Queries.Movies
{
    public class GetReactionsQueryHandler : IRequestHandler<GetReactionsQuery, ReactionDTO>
    {
        private readonly MovieContext _context;

        public GetReactionsQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<ReactionDTO> Handle(GetReactionsQuery request, CancellationToken cancellationToken)
        {
            var reactions = await _context
                .MovieReactions
                .AsNoTracking()
                .Where(m => m.UserId == request.UserId && (m.Liked || m.Disliked))
                .ToListAsync();

            var likeds = reactions.Where(r => r.Liked).Select(r => r.MovieId);
            var dislikeds = reactions.Where(r => r.Disliked).Select(r => r.MovieId);

            return new ReactionDTO
            {
                Likeds = likeds,
                Dislikeds = dislikeds
            };
        }
    }
}
