using Adoption.Domain.Offert.Aggregatates;
using Adoption.Domain.Offert.Repositiories;
using Adoption.Domain.Offert.ValueObjects;
using Adoption.Infrastructure.EF.Contexts.Write;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Repositories
{
    internal sealed class OffertRepository : IOffertRepository
    {
        private readonly DbSet<Offert> _offerts;
        private readonly WriteDbContext _writeDbContext;

        public OffertRepository(WriteDbContext writeDbContext)
        {
            _offerts = writeDbContext.Offerts;
            _writeDbContext = writeDbContext;
        }

        public async Task AddAsync(Offert offert)
        {
            await _offerts.AddAsync(offert);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Offert offert)
        {
            _offerts.Remove(offert);
            await _writeDbContext.SaveChangesAsync();
        }

        public Task<Offert?> GetAsync(OffertId id)
            => _offerts.Include("_applications")
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();
        

        public async Task UpdateAsync(Offert offert)
        {
            _offerts.Update(offert);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}
