using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.ValueObjects
{
    public sealed record Email
    {
        public string Value { get; }

        public Email(string value)
        {
            if (!value.Contains('@'))
            {
                //throw new InvalidEmailException(value);
            }

            Value = value;
        }

    public static implicit operator string(Email email) => email.Value;
    public static implicit operator Email(string email) => new Email(email);
    }

}
