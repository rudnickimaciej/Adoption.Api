using Adoption.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Policies
{
    internal interface IOffertStatusPolicy
    {
        bool CanBeApplied(UserRole role);
        bool CanBeChanged();
    }
}
