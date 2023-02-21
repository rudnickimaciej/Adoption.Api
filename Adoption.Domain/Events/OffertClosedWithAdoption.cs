using Adoption.Domain.Aggregates;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.DomainEvents
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
