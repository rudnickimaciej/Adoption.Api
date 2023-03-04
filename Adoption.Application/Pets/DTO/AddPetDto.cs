using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.Pets.DTO
{
    public class AddPetDto
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
    }
}
