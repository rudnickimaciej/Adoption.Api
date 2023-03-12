using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Auth.Exceptions
{
    public class InvalidEmailException : CustomException
    {
        public string Email { get; }
        public InvalidEmailException(string email) : base($"Email is invalid: '{email}'")
        {
            Email = email;
        }
    }
}
