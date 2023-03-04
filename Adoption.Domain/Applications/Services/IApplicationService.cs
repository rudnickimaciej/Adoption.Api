using Adoption.Domain.Applications.Entities;
using Adoption.Domain.Offerts.Aggregates;


namespace Adoption.Domain.Applications.Services
{
    public interface IApplicationService
    {
        void Apply(Offert offert, Application application, IEnumerable<Application> applicationsFromLastMonth);
    }
}
