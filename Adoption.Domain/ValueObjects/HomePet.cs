using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.ValueObjects
{
    public sealed record HomePet
    {
        public int Age { get; }
        public Breed Breed { get; } //Value Object

    }
}
