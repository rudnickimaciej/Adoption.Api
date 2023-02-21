using Adoption.Domain.Entities;
using Adoption.Domain.Repositiories;

namespace Adoption.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();
        public async Task AddAsync(User user)
        {
            _users.Add(user);
        }

        public Task DeleteAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetAsync(Guid id)
        {
           return  Task.FromResult(_users.Where(u => u.Id == id).FirstOrDefault());
        }

        public Task<User?> GetByEmailAsync(string email)
        {
            return Task.FromResult(_users.Where(u => u.Email == email).FirstOrDefault());
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
