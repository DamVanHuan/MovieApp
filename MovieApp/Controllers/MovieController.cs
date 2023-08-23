using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Applications.Queries.Movies;

namespace MovieApp.Controllers
{
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMoviesAsync([FromQuery] GetMoviesQuery model)
        {
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }
    }
}   