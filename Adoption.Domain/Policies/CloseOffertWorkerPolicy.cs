using Adoption.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Policies
{
    internal class CloseOffertWorkerPolicy : ICloseOffertPolicy
    {
        public void CloseOffert()
        {
            throw new NotImplementedException();
        }

        public bool IsApplicable(UserRole role)
        {
            return role.Value == UserRole.Worker;
        }
    }
}
