using Adoption.Application.Offerts.DTO;
using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Offerts.Queries
{
    public class GetOffertHandler : IQueryHandler<GetOffert,OffertDto>
    {
        public Guid Id { get; set; }

        public Task<OffertDto> HandleAsync(GetOffert query)
        {
             throw new NotImplementedException(); 
        }
    }
}
