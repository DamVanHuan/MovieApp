using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Applications.Commands.Users;

namespace MovieApp.Controllers
{
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] RegisterUserCommand model)
        {
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand model)
        {
            var resp = await _mediator.Send(model);
            return Ok(resp);
        }
    }
}   