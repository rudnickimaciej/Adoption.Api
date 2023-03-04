using Adoption.Domain.Offerts.Aggregates;
using Adoption.Shared.Abstractions.Exceptions;


namespace Adoption.Domain.Applications.Exceptions
{
    public sealed class CanNotApplyBecauseUserHasWithdrawTooManyTimes : CustomException
    {
        public CanNotApplyBecauseUserHasWithdrawTooManyTimes(Offert offert)
            : base("User can not apply to the offert because he/she has withdraw applications 3 times during last month.")
        {
            Offert = offert;
        }

        public Offert Offert { get; }
    }
}
