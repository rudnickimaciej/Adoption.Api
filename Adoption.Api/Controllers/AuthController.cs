using Adoption.Application.Exceptions;
using Adoption.Application.Services.Authentication;
using Adoption.Auth.Authentication;
using Microsoft.AspNetCore.Mvc;
using OneOf;

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

            OneOf<AuthenticationResult, UserAlreadyExistsException> registerResult = await _authenticationService.Register(
                registerRequest.FirstName,
                registerRequest.LastName,
                registerRequest.Email,
                registerRequest.Password);

            return registerResult.Match(
                authResult => Ok(authResult),
                _ => Problem(statusCode: StatusCodes.Status409Conflict, title: _.InnerException.Message));

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