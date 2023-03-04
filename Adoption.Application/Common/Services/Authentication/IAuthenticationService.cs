using Adoption.Application.Offerts.OffertsExceptions;
using OneOf;

namespace Adoption.Application.Common.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<OneOf<AuthenticationResult, UserAlreadyExistsException>> Register(string firstName, string lastName, string email, string password);
        Task<AuthenticationResult> Login(string email, string password);

    }
}
