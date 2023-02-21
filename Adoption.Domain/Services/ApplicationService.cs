using Adoption.Domain.Aggregates;
using Adoption.Domain.Exceptions;
using Adoption.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
