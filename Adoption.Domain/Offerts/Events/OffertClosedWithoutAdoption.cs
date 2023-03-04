using Adoption.Domain.Offerts.Aggregates;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.Offerts.Events
{
    public sealed class OffertClosedWithoutAdoption : IDomainEvent
    {
        public Offert Offert { get; }
        internal OffertClosedWithoutAdoption(Offert offert)
        {
            Offert = offert;
        }

    }
}
