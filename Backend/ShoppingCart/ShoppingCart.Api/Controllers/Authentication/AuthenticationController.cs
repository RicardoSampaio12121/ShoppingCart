using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Api.Controllers.Base;

namespace ShoppingCart.Api.Controllers.Authentication
{
    [ApiController]
    [Route("authentication")]
    public class AuthenticationController : BaseController
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
