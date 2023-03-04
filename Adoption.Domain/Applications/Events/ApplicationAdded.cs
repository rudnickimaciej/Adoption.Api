using Adoption.Domain.Applications.Entities;
using Adoption.Shared.Abstractions.Domain;

namespace Adoption.Domain.Applications.Events
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
