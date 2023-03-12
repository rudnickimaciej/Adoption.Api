using Adoption.Application.Common.Services.Authentication;
using Adoption.Auth.Exceptions;
using Adoption.Shared.Abstractions.Exceptions;
using OneOf;

namespace Adoption.Auth.Services
{
    public interface IAuthenticationService
    {
        Task<OneOf<AuthenticationResult, CustomException>> Register(string firstName, string lastName, string email, string password);
        Task<OneOf<AuthenticationResult, InvalidCredentialsException>> Login(string email, string password);

    }
}
