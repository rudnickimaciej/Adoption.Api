using Adoption.Domain.Aggregates;
using Adoption.Domain.Entities;
using Adoption.Domain.Exceptions;

namespace Adoption.Domain.Services
{
    internal sealed class ApplicationService: IApplicationService
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
