﻿using Adoption.Application.Offerts.DTO;
using Adoption.Application.Offerts.Queries;
using Adoption.Infrastructure.DTO;
using Adoption.Infrastructure.EF.Contexts.Read;
using Adoption.Infrastructure.EF.Queries.Handlers;
using Adoption.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Queries
{
    internal sealed class GetOffertHandler : IQueryHandler<GetOffert,OffertDto>
    {
        private readonly DbSet<OffertReadModel> _offerts;

        public GetOffertHandler(ReadDbContext ctx)
            => _offerts = ctx.Offerts;

        public async Task<OffertDto?> HandleAsync(GetOffert query)
            => await _offerts
            .Where(o => o.Id == query.Id)
            .Select(o => o.AsDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
    }
}
