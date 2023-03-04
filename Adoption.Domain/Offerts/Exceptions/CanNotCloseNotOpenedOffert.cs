using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adoption.Domain.Offerts.Aggregates;

namespace Adoption.Domain.Offerts.Exceptions
{
    internal sealed class CanNotCloseNotOpenedOffert : CustomException
    {
        public Offert Value { get; set; }

        public CanNotCloseNotOpenedOffert(Offert value) : base("Cannot close not opened offert")
        {
            Value = value;
        }
    }
}
