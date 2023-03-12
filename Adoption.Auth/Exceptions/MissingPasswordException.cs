using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Auth.Exceptions
{
    public class MissingPasswordException : CustomException
    {
        public MissingPasswordException() : base($"Invalid password")
        {

        }
    }
}
