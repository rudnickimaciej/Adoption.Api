using Adoption.Application.DTO;
using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Queries
{
    public class GetOffertHandler : IQueryHandler<GetOffert,OffertDto>
    {
        public Guid Id { get; set; }

        public Task<OffertDto> HandleAsync(GetOffert query)
        {
             
        }
    }
}
