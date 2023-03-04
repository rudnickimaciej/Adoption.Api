using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adoption.Application.DTO;

namespace Adoption.Application.Offerts.DTO
{
    public class OffertDto
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public string Description { get; set; }
        public IEnumerable<ApplicationDto> Applications { get; set; }
    }
}
