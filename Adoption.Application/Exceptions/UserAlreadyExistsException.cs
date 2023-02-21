using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Application.Exceptions
{
    public class UserAlreadyExistsException : CustomException
    {
        public UserAlreadyExistsException() : base($"User already exists.")
        {
        }
    }
}
