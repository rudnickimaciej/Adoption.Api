using Adoption.Auth.EF.Contexts;
using Adoption.Auth.Entities;
using Adoption.Auth.Repositiories;
using Microsoft.AspNetCore.Identity;

namespace Adoption.Infrastructure.Domain.Users
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext _userDbContext { get; set; }
        private UserManager<IdentityUser> _userManager { get; set; }

        private static readonly List<User> _users = new() {
            new User()
            { FirstName = "Maciek",
                LastName = "Rudnicki",
                Email = "maciejrudnicki@outlook.com",
                Password = "password"
            } };

        public UserRepository(UserDbContext userDbContext, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _userDbContext = userDbContext;
        }

        public async Task AddAsync(User user)
        {
            await _userManager.CreateAsync(new IdentityUser()
            {
                Email = user.Email,
                UserName = user.FirstName
            }, user.Password);
            //await _userDbContext.AddAsync(user, user.Password);
            //_users.Add(user);
        }

        public Task DeleteAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetAsync(Guid id)
        {
            return Task.FromResult(_users.Where(u => u.Id == id).FirstOrDefault());
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
