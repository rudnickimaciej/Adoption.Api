using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Offerts.ValueObjects
{
    public sealed record OffertDescription
    {
        public string Value { get; }

        public OffertDescription(string value)
        {
            if (!value.Any())
            {
                //throw new DescriptionIsEmptyException
            }

            Value = value;
        }

        public static implicit operator string(OffertDescription description) => description.Value;
        public static implicit operator OffertDescription(string description) => new OffertDescription(description);
    }

}
