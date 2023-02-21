using Adoption.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Entities
{
    //Jakie pytania moga być w Surveyu? 
    public class Survey
    {
        public Guid Id { get; set; }
        public ICollection<HomePet> HomePets { get; set; }


    }
}
