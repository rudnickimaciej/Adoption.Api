using Adoption.Domain.Pets.Entities;

namespace Adoption.Domain.Users.Repositiories
{
    public interface IPetRepository
    {
        Task<Pet?> GetAsync(Guid id);
        Task AddAsync(Pet user);
        Task UpdateAsync(Pet user);
        Task DeleteAsync(Pet user);
    }
}
