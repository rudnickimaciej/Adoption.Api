
using Adoption.Domain.Applications.Entities;
using Adoption.Domain.Applications.Exceptions;
using Adoption.Domain.Offerts.Aggregates;

namespace Adoption.Domain.Applications.Services
{
    internal sealed class ApplicationService : IApplicationService
    {
        void IApplicationService.Apply(Offert offert, Application application, IEnumerable<Application> applicationsFromLastMonth)
        {
            if (applicationsFromLastMonth
                .Where(a => a.Status == ApplicationStatus.WithdrawedByApplicant)
                .Count() > 3)
            {
                throw new CanNotApplyBecauseUserHasWithdrawTooManyTimes(offert);
            }
            offert.AddApplication(application);
        }
    }
}
