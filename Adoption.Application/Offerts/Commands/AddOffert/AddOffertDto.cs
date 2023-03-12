using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.Offerts.Commands.AddOffert
{
    public class AddOffertDto
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public string Description { get; set; }
    }
}
