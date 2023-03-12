using Adoption.Domain.Offerts.Aggregates;
using Adoption.Domain.Offerts.Repositiories;
using Adoption.Domain.Offerts.ValueObjects;
using Adoption.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.Domain.Offerts
{
    internal sealed class OffertRepository : IOffertRepository
    {
        private readonly AppDbContext _appDbContext;

        public OffertRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Offert offert)
        {
            await _appDbContext.Offerts.AddAsync(offert);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Offert offert)
        {
            _appDbContext.Offerts.Remove(offert);
            await _appDbContext.SaveChangesAsync();
        }

        public Task<Offert?> GetAsync(OffertId id)
            => _appDbContext.Offerts.Include("_applications")
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();


        public async Task UpdateAsync(Offert offert)
        {
            _appDbContext.Offerts.Update(offert);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
