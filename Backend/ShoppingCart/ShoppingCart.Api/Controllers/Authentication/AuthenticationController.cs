using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Api.Controllers.Base;

namespace ShoppingCart.Api.Controllers.Authentication
{
    public class AuthenticationController : BaseController
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
        }

    }
}
