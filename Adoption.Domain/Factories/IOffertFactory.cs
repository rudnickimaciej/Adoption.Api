using Adoption.Domain.Aggregates;
using Adoption.Domain.Entities;
using Adoption.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Factories
{
    public interface IOffertFactory
    {
        Task<Offert> Create(Guid petId, string description);
        Offert CreateWithDefaultApplications(OffertId id, OffertStatus status, IEnumerable<Application> applications);
    }
}
