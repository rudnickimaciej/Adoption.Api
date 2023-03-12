using Adoption.Domain.Common.Exceptions;

namespace Adoption.Domain.Persons.ValueObjects
{
    public class PersonId
    {
        public Guid Value { get; }

        public PersonId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new InvalidEntityIdException(value);
            }

            Value = value;
        }

        public static implicit operator Guid(PersonId user)
            => user.Value;

        public static implicit operator PersonId(Guid id) 
            => new PersonId(id);

        public static implicit operator string(PersonId userId) 
            => userId.Value.ToString();

        public static implicit operator PersonId?(string? value) 
            => string.IsNullOrWhiteSpace(value) ? null : Guid.Parse(value);
    }

}
