using Adoption.Domain.Aggregates;
using Adoption.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Services
{
    public interface IApplicationService
    {
        void Apply(Offert offert, Application application, IEnumerable<Application> applicationsFromLastMonth);
    }
}
