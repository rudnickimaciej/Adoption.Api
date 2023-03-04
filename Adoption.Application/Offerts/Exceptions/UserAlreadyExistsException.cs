using Adoption.Shared.Abstractions.Exceptions;
using System.Net;

namespace Adoption.Application.Offerts.OffertsExceptions
{
    public class UserAlreadyExistsException : CustomException
    {
        public UserAlreadyExistsException() : base($"User already exists.")
        {
        }
    }
}
