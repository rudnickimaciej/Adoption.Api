using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adoption.Domain.ValueObjects;
namespace Adoption.Domain.Entities
{
    public sealed class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName{ get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
