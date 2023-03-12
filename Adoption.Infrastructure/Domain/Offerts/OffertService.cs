using Adoption.Application.Offerts.Services;
using Adoption.Infrastructure.Database;

namespace AAdoption.Infrastructure.Offerts 
{
    public class OffertService : IOffertService
    {
        private AppDbContext _appDbContext { get; set; }
        public OffertService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        Task<bool> IOffertService.ExistsByPetId(Guid petId)
        {
            return Task.FromResult(_appDbContext.Offerts.Any(o => o.PetId.Value == petId));
        }
    }
}
