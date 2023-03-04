using Adoption.Application.Offerts.DTO;
using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Offerts.Queries
{
    public class GetOffert : IQuery<OffertDto>
    {
        public Guid Id { get; set; }
    }
}
