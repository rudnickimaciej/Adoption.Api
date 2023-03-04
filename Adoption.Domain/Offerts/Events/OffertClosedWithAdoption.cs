using Adoption.Domain.Offerts.Aggregates;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.Offerts.Events
{
    public sealed class OffertClosedWithAdoption : IDomainEvent
    {
        public Offert Offert { get; }
        internal OffertClosedWithAdoption(Offert offert)
        {
            Offert = offert;
        }

    }
}
