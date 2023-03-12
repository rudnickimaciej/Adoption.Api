using Adoption.Shared.Abstractions.Command;
using MediatR;

namespace Adoption.Application.Users.Commands.RegisterUser
{
    public class RegisterUserCommand : CommandBase<Unit>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Password { get; }
    }
}
