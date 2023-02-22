using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.Exceptions
{
    public class OffertWithPetIdAlreadyExistsException: CustomException
    {
        public OffertWithPetIdAlreadyExistsException(Guid PetId) : base("Offert for this Pet already exists.")
        {
            this.PetId = PetId;
        }

        public Guid PetId { get; private  set; }
    }
}
