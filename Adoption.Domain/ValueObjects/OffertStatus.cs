using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.ValueObjects
{
    //public sealed record OffertStatus(string Value)
    //{
    //    public const string NotStarted = nameof(NotStarted);
    //    public const string InProgress = nameof(InProgress);
    //    public const string EndedWithAdoption = nameof(EndedWithAdoption);
    //    public const string EndedWithoutAdoption = nameof(EndedWithoutAdoption);

    //    public static implicit operator string(OffertStatus status) => status.Value;
    //    public static implicit operator OffertStatus(string value) => new(value);
    //}

    public enum OffertStatus
    {
        NotStarted,
        InProgress,
        EndedWithAdoption,
        EndedWithoutAdoption,    
    }
}
