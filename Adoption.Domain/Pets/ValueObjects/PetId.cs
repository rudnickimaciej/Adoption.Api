using Adoption.Domain.Exceptions;
namespace Adoption.Domain.Pets.ValueObjects
{
    public sealed record PetId
    {
        public Guid Value { get; }

        public PetId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new InvalidAggregateIdException(value);
            }
            Value = value;
        }
    }
}
