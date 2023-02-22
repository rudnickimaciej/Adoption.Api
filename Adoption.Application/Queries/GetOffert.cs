using Adoption.Application.DTO;
using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Queries
{
    public class GetOffert : IQuery<OffertDto>
    {
        public Guid Id { get; set; }
    }
}
