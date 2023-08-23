using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Applications.Commands;
using MovieApp.Applications.Queries.Movies;
using System.Security.Claims;

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

        [Authorize]
        [HttpPost("{id:int}/like")]
        public async Task<IActionResult> LikeMovieAsync([FromRoute] int id)
        {
            var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "0");
            var model = new LikeMovieCommand(id, currentUserId);
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }
    }
}