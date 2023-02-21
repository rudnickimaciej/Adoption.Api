using Adoption.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.ValueObjects
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
