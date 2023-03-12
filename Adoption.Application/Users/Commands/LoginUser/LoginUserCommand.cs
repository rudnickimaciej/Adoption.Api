using Adoption.Application.Common.Services.Authentication;
using Adoption.Shared.Abstractions.Command;
using MediatR;

namespace Adoption.Application.Users.Commands.LoginUser
{
    public class LoginUserCommand : CommandBase<AuthenticationResult>
    {
        public LoginUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get;}
        public string Password { get;}
    }
}
