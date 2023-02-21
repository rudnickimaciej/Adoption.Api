using Adoption.Domain.Aggregates;
using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Exceptions
{
    public sealed class CanNotApplyBecauseUserHasWithdrawTooManyTimes : CustomException
    {
        public CanNotApplyBecauseUserHasWithdrawTooManyTimes(Offert offert)
            : base("User can not apply to the offert because he/she has withdraw applications 3 times during last month.")
        {
            Offert = offert;
        }

        public Offert Offert{ get;}
    }
}
