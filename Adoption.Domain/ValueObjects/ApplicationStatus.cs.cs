using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.ValueObjects
{
    public sealed record ApplicationStatus(string Value)
    {
        public const string NotOpened = nameof(NotOpened);
        public const string InProgress = nameof(InProgress);
        public const string InFinalization = nameof(InFinalization);
        public const string RejectedByWorker = nameof(RejectedByWorker);
        public const string WithdrawedByApplicant = nameof(WithdrawedByApplicant);
        public const string ClosedDueToAnotherApplicationSuccess = nameof(ClosedDueToAnotherApplicationSuccess);

        public static implicit operator string(ApplicationStatus status) => status.Value;

        public static implicit operator ApplicationStatus(string value) => new(value);
    }
}
