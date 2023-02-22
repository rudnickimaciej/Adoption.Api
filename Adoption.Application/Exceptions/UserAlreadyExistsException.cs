using Adoption.Shared.Abstractions.Exceptions;
using System.Net;

namespace Adoption.Application.Exceptions
{
    public class UserAlreadyExistsException : CustomException
    {
        public UserAlreadyExistsException() : base($"User already exists.")
        {
        }
    }
}
