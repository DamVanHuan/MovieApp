using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Movies;

namespace MovieApp.Applications.Queries.Movies
{
    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, ListResult<MovieDTO>>
    {
        private readonly MovieContext  _context;
        private readonly IMapper _mapper;

        public GetMoviesQueryHandler(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListResult<MovieDTO>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            var movies = await _context
                .Movies
                .AsNoTracking()
                .OrderBy(m => m.Title)
                .Skip(request.Offset)
                .Take(request.Limit + 1)
                .ToListAsync();

            bool hasNext = movies.Count > request.Limit;
            if (hasNext)
            {
                movies.RemoveAt(movies.Count - 1);
            }

            var movieDTOs = _mapper.Map<List<MovieDTO>>(movies); 

            return new ListResult<MovieDTO>
            {
                HasNext = hasNext,
                Items = movieDTOs
            };
        }
    }
}
