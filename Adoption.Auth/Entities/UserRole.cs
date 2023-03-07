using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Users.ValueObjects
{
    public sealed record UserRole(string Value)
    {
        public const string Applicant = nameof(Applicant);
        public const string Worker = nameof(Worker);

        public static implicit operator string(UserRole role) => role.Value;
        public static implicit operator UserRole(string value) => new(value);
    }
}
