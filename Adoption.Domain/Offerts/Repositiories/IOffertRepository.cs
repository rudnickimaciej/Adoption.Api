
using Adoption.Domain.Offerts.Aggregates;
using Adoption.Domain.Offerts.ValueObjects;

namespace Adoption.Domain.Offerts.Repositiories
{
    public interface IOffertRepository
    {
        Task<Offert> GetAsync(OffertId id);
        Task AddAsync(Offert offert);
        Task UpdateAsync(Offert offert);
        Task DeleteAsync(Offert offert);
    }
}
