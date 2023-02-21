using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.ValueObjects
{
    public sealed class Breed
    {
        public string Name { get; }
        public Breed(string name)
        {
            Name = name;
        }

    }
}
