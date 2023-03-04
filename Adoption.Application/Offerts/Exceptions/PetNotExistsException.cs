using Adoption.Shared.Abstractions.Exceptions;

namespace Adoption.Application.Offerts.Exceptions
{
    public class PetNotExistsException : CustomException
    {
        public PetNotExistsException(Guid PetId) : base($"Pet with {PetId} id does not exist.")
        {
            this.PetId = PetId;
        }

        public Guid PetId { get; private  set; }
    }
}
