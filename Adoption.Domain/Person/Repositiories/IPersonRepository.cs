
using Adoption.Domain.Persons.Entities;

namespace Adoption.Domain.Users.Repositiories
{
    public interface IPersonRepository
    {
        Task<Person?> GetAsync(Guid id);
        Task<Person?> GetByEmailAsync(string email);

        Task AddAsync(Person user);
        Task UpdateAsync(Person user);
        Task DeleteAsync(Person user);
    }
}
