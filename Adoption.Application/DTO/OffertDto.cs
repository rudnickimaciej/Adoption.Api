using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.DTO
{
    public class OffertDto
    {
        public Guid PetId { get; set; }
        public string Description { get; set; }
        public IEnumerable<ApplicationDto> Applications{ get; set; }
    }
}
