using Adoption.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Entities
{
    public class Contact
    {
        public Guid Id { get; private set; }
        public Email Email { get; private set; }
    }
}
