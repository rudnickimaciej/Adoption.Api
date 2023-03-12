using Adoption.Domain.Pets.Entities;
using Adoption.Domain.Pets.Repositiories;
using Adoption.Infrastructure.Database;

namespace Adoption.Infrastructure.Domain.Pets
{
    public class PetRepository : IPetRepository
    {
        private AppDbContext _appDbContext { get; set; }
        public PetRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public Task AddAsync(Pet user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Pet user)
        {
            throw new NotImplementedException();
        }

        public Task<Pet?> GetAsync(Guid id)
        {

            return Task.FromResult(_appDbContext.Pets.Where(p => p.Id.Value == id).FirstOrDefault());

        }

        public Task UpdateAsync(Pet user)
        {
            throw new NotImplementedException();
        }
    }
}
