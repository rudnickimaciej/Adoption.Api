using Adoption.Domain.Offerts.Aggregates;
using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Domain.Offerts.Exceptions
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
