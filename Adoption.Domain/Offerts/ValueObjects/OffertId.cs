using Adoption.Domain.Common;
using Adoption.Domain.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Offerts.ValueObjects
{
    public record OffertId
    {
        public Guid Value { get; }
        public OffertId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new InvalidAggregateIdException(value);
            }
            Value = value;
        }

        public static AggregateId Create() => new(Guid.NewGuid());

        public static implicit operator Guid(OffertId id) => id.Value;
        public static implicit operator OffertId(Guid id) => new(id);
        public override string ToString() => Value.ToString();
    }
}
