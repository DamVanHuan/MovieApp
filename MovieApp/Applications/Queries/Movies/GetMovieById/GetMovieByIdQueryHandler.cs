using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DTOs.Exceptions;
using MovieApp.DTOs.Movies;

namespace MovieApp.Applications.Queries.Movies
{
    public class GetMovieByIdQueryHandler : IRequestHandler<GetMovieByIdQuery, MovieDTO>
    {
        private readonly MovieContext _context;
        private readonly IMapper _mapper;

        public GetMovieByIdQueryHandler(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<MovieDTO> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movie = await _context.Movies.AsNoTracking().FirstOrDefaultAsync(m => m.Id == request.Id);  
            if (movie == null)
            {
                throw new BadRequestException("MovieNotFound", "Movie not found");
            }

            return _mapper.Map<MovieDTO>(movie);
        }
    }
}
