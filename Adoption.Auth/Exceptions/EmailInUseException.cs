
using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Auth.Exceptions
{
    public class EmailInUseException : CustomException
    {

        public EmailInUseException() : base($"Email is already in use.")
        {
        }
    }
}
