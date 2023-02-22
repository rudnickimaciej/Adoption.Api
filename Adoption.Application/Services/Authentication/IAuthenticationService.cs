using Adoption.Application.Exceptions;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<OneOf<AuthenticationResult, UserAlreadyExistsException>> Register(string firstName, string lastName, string email, string password);
        Task<AuthenticationResult> Login(string email, string password);

    }
}
