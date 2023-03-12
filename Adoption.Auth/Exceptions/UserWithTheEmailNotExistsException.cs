using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Auth.Exceptions
{
    public class UserWithTheEmailNotExistsException : CustomException
    {

        public UserWithTheEmailNotExistsException() : base($"User not exists.")
        {
        }
    }
}
