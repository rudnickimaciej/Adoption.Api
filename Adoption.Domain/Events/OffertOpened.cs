using Adoption.Domain.Aggregates;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.DomainEvents
{
    public sealed class OffertOpened : IDomainEvent
    {
        public Offert Application { get; }
        internal OffertOpened(Offert application)
        {
            Application = application;
        }
    }
}
