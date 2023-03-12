using Adoption.Application.Offerts.Queries.GetOffert;
using Adoption.Domain.Offerts.Aggregates;
using Adoption.Infrastructure.Database;
using Adoption.Shared.Abstractions.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.Domain.Offerts.Queries
{
    public class GetOffertQueryHandler : IQueryHandler<GetOffertQuery, OffertDto>
    {
        private readonly DbSet<Offert> _offerts;

        public GetOffertQueryHandler(AppDbContext appDbContext)
        {
            _offerts = appDbContext.Offerts;
        }

        public async Task<OffertDto?> Handle(GetOffertQuery request, CancellationToken cancellationToken)
        {
            return await _offerts
                .Include(o => o.Applications)
                .Where(o => o.Id.Value == request.Id)
                .Select(o => o.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
        }
    }
}
