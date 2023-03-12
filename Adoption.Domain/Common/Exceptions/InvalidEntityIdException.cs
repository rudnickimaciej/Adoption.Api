using Adoption.Shared.Abstractions.Exceptions;


namespace Adoption.Domain.Common.Exceptions
{
    public class InvalidEntityIdException : CustomException
    {
        public Guid Id { get; }
        public InvalidEntityIdException(Guid id) : base($"Invalid entity id: {id}")
        =>  Id = id;
    }
}
