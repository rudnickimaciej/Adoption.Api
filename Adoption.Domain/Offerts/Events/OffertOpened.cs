using Adoption.Domain.Offerts.Aggregates;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.Offerts.Events
{
    public sealed class OffertPublished : IDomainEvent
    {
        public Offert Application { get; }
        internal OffertPublished(Offert application)
        {
            Application = application;
        }
    }
}
