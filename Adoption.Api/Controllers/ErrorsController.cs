using Adoption.Application.Services.Authentication;
using Adoption.Auth.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ErrorsController : ControllerBase
    {
      

        public ErrorsController(ILogger<AuthController> logger, IAuthenticationService authenticationService)
        {
          
        }

        [HttpPost]
        public async Task<IActionResult> Error()
        {

            return Problem();
        }
    }
}