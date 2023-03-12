using Adoption.Auth.Services;
using Adoption.Shared.Abstractions.Command;
using System.ComponentModel.DataAnnotations;
using Adoption.Auth.Exceptions;
using Adoption.Auth.Repositiories;
using Microsoft.AspNetCore.Identity;
using MediatR;

namespace Adoption.Application.Users.Commands.RegisterUser
{
    public record RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, Unit>
    {
        private readonly IAuthenticationService _authService;
        private static readonly EmailAddressAttribute EmailAddressAttribute = new();
        private IUserRepository _userRepository;
        private UserManager<IdentityUser> _userManager { get; set; }

        public RegisterUserCommandHandler(IAuthenticationService authService, IUserRepository userRepository, UserManager<IdentityUser> userManager)
        {
            _authService = authService;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<Unit> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(command.Email) || !EmailAddressAttribute.IsValid(command.Email))
            {
                throw new InvalidEmailException(command.Email);
            }
            if (string.IsNullOrWhiteSpace(command.Password))
            {
                throw new MissingPasswordException();
            }

            var user = await _userRepository.GetByEmailAsync(command.Email);

            if (user is not null)
            {
                throw new EmailInUseException();

            }
            var result = await _userManager.CreateAsync(new IdentityUser()
            {
                Email = command.Email,
                UserName = command.FirstName
            }, command.Password);
            
            return Unit.Value;
        }
    }
}
