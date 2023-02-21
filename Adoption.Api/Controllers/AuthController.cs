using Adoption.Application.Services.Authentication;
using Adoption.Auth.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthenticationService _authenticationService;

        public AuthController(ILogger<AuthController> logger, IAuthenticationService authenticationService)
        {
            _logger = logger;
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            AuthenticationResult authResult = await _authenticationService.Register(
                registerRequest.FirstName,
                registerRequest.LastName,
                registerRequest.Email,
                registerRequest.Password);

            return Ok(authResult);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            AuthenticationResult authResult = await _authenticationService.Login(
                loginRequest.Email,
                loginRequest.Password);

            return Ok(authResult);

        }
    }
}