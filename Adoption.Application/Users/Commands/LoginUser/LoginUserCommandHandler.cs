using Adoption.Auth.Services;
using Adoption.Shared.Abstractions.Command;
using System.ComponentModel.DataAnnotations;
using Adoption.Auth.Exceptions;
using Adoption.Auth.Repositiories;
using Microsoft.AspNetCore.Identity;
using Adoption.Auth;
using Adoption.Application.Common.Services.Authentication;
using MediatR;

namespace Adoption.Application.Users.Commands.LoginUser
{
    public record LoginUserCommandHandler : ICommandHandler<LoginUserCommand, AuthenticationResult>
    {
        private readonly IAuthenticationService _authService;
        private static readonly EmailAddressAttribute EmailAddressAttribute = new();
        private IUserRepository _userRepository;
        private UserManager<IdentityUser> _userManager { get; set; }
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public LoginUserCommandHandler(IAuthenticationService authService, IUserRepository userRepository, UserManager<IdentityUser> userManager)
        {
            _authService = authService;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<AuthenticationResult> Handle(LoginUserCommand command, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(command.Email) || !EmailAddressAttribute.IsValid(command.Email))
            {
                throw new InvalidEmailException(command.Email);
            }
            if (string.IsNullOrWhiteSpace(command.Password))
            {
                throw new MissingPasswordException();
            }

            var user = await _userManager.FindByEmailAsync(command.Email);

            if (user is null)
            {
                throw new InvalidCredentialsException();

            }
            if (!await _userManager.CheckPasswordAsync(user, command.Password))
            {
                throw new InvalidCredentialsException();
            }

            var token = _jwtTokenGenerator.GenerateToken(Guid.Parse(user.Id), user.UserName, user.UserName);

            return new AuthenticationResult(
                Guid.Parse(user.Id),
                user.UserName,
                user.Email,
                token);

        }
    }
}
