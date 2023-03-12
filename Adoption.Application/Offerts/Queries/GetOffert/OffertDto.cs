using Adoption.Application.Queries.Commands.GetApplicationDetails;

namespace Adoption.Application.Offerts.Queries.GetOffert
{
    public class OffertDto
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public string Description { get; set; }
        public IEnumerable<ApplicationDetailsDto> Applications { get; set; }
    }
}
