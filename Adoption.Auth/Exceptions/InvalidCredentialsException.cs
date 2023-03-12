
using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Auth.Exceptions
{
    public class InvalidCredentialsException : CustomException
    {

        public InvalidCredentialsException() : base($"Wrong credentials")
        {
        }
    }
}
