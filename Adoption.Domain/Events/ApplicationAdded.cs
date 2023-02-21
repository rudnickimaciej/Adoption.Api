using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.DomainEvents
{
    public sealed class ApplicationAdded: IDomainEvent
    {
        public Application Application { get; }
        internal ApplicationAdded(Application application)
        {
            Application = application;
        }

    }
}
