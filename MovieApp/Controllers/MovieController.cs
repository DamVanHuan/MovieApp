using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Applications.Commands.Movies;
using MovieApp.Applications.Queries.Movies;
using System.Security.Claims;

namespace MovieApp.Controllers
{
    [Authorize]
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        private int _currentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "0");

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

        [HttpPost("{id:int}/like")]
        public async Task<IActionResult> LikeMovieAsync([FromRoute] int id)
        {
            var model = new LikeMovieCommand(id, _currentUserId);
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }

        [HttpPost("{id:int}/dislike")]
        public async Task<IActionResult> DislikeMovieAsync([FromRoute] int id)
        {
            var model = new DislikeMovieCommand(id, _currentUserId);
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }

        [HttpGet("reactions")]
        public async Task<IActionResult> GetReactionsAsync()
        {
            var model = new GetReactionsQuery(_currentUserId);
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMovieAsync([FromRoute] int id)
        {
            var model = new GetMovieByIdQuery(id);
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }
    }
}