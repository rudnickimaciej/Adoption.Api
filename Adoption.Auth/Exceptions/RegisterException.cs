
using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Auth.Exceptions
{
    public class RegisterException : CustomException
    {

        public RegisterException() : base($"Something went wrong while registering user")
        {
        }
    }
}
