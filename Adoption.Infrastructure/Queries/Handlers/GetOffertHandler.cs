using Adoption.Application.DTO;
using Adoption.Application.Queries;
using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Infrastructure.Queries
{
    public class GetOffertHandler : IQueryHandler<GetOffert,OffertDto>
    {
        public Guid Id { get; set; }

        public Task<OffertDto> HandleAsync(GetOffert query)
        {
             
        }
    }
}
