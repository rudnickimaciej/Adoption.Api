using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Application.Offerts.Exceptions
{
    public class UserWithTheEmailNotExistsException : CustomException
    {
       
        public UserWithTheEmailNotExistsException() : base($"User not exists.")
        {
        }
    }
}
