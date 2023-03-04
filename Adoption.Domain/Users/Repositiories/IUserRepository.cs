
using Adoption.Domain.Users.Entities;

namespace Adoption.Domain.Users.Repositiories
{
    public interface IUserRepository
    {
        Task<User?> GetAsync(Guid id);
        Task<User?> GetByEmailAsync(string email);

        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
    }
}
