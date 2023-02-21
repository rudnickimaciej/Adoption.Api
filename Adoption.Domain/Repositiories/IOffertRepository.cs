using Adoption.Domain.Aggregates;

namespace Adoption.Domain.Repositiories
{
    public interface IOffertRepository
    {
        Task<Offert> GetAsync(OffertId id);
        Task AddAsync(Offert offert);
        Task UpdateAsync(Offert offert);
        Task DeleteAsync (Offert offert);
    }
}
