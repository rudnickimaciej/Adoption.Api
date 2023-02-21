using Adoption.Domain.Aggregates;
using Adoption.Domain.Exceptions;
using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddAdoption.DomainExceptions
{
    public class OffertAlreadyOpenedException : CustomException
    {
        public Offert Offert { get; }
        public OffertAlreadyOpenedException(Offert offert) : base("Offert can not be opened because it is already opened")
        {
            Offert = offert;
        }
    }
}
