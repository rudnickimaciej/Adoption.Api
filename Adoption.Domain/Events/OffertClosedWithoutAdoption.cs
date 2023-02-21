using Adoption.Domain.Aggregates;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.DomainEvents
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
