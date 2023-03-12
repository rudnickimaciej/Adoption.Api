using Adoption.Application.Common.Services.Authentication;
using Adoption.Application.Users.Commands;
using Adoption.Application.Users.Commands.RegisterUser;
using Adoption.Auth.Authentication;
using Adoption.Auth.Exceptions;
using Adoption.Infrastructure.Database;
using Adoption.Shared.Abstractions.Command;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OneOf;
using System.Security.Claims;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthController : ControllerBase
    { 

        private readonly ILogger<AuthController> _logger;
        private readonly Auth.Services.IAuthenticationService _authenticationService;
        private readonly SqlServerOptions _sqlServerOptions;
        //private readonly ICommandDispatcher _commandDispatcher;

        public AuthController(
            ILogger<AuthController> logger,
            Auth.Services.IAuthenticationService authenticationService
            //ICommandDispatcher commandDispatcher
            )
        {
            _logger = logger;
            _authenticationService = authenticationService;
            //_commandDispatcher = commandDispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserCommand command)
        {
            //await _commandDispatcher.DispatchAsync(command);
            return Ok("User registered sucessfully ");

            //OneOf<AuthenticationResult, UserAlreadyExistsException> registerResult = await _authenticationService.Register(
            //    registerRequest.FirstName,
            //    registerRequest.LastName,
            //    registerRequest.Email,
            //    registerRequest.Password);

            //return registerResult.Match(
            //    authResult => Ok(authResult),
            //    _ => Problem(statusCode: StatusCodes.Status409Conflict, title: _.InnerException.Message));

        }
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized, title: "Access denied");

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            OneOf<AuthenticationResult, InvalidCredentialsException> authResult = await _authenticationService.Login(
                loginRequest.Email,
                loginRequest.Password);

            return authResult.Match(
                authResult => Ok(authResult),
                _ => Problem(statusCode: StatusCodes.Status401Unauthorized, title: "Wrong credentials"));

            //return Ok(authResult);
            //if (loginRequest.Email == "maciejrudnicki@outlook.com" && loginRequest.Password == "password")
            //{
            //    var claims = new List<Claim> {
            //        new Claim(ClaimTypes.Name,"maciej rudnicki"),
            //        new Claim(ClaimTypes.Email,loginRequest.Email),
            //        new Claim("Department","HR")
            //    };

            //    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
            //    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            //    var authenticationProperties = new AuthenticationProperties()
            //    {
            //        IsPersistent = true
            //    };
            //    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal, authenticationProperties);

            //    return Ok();
            //}
            //return Problem(statusCode: StatusCodes.Status401Unauthorized, title: "Invalid credentials");

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return Ok();
        }
    }
}