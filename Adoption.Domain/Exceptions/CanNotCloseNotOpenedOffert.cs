using Adoption.Domain.Aggregates;
using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Exceptions
{
    internal sealed class CanNotCloseNotOpenedOffert:CustomException
    {
        public Offert Value { get; set; }

        public CanNotCloseNotOpenedOffert(Offert value):base("Cannot close not opened offert")
        {
            Value = value;
        }
    }
}
