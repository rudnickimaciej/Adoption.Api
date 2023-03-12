namespace Adoption.Application.Offerts.Services
{
    public interface IOffertService
    {
        Task<bool> ExistsByPetId(Guid petId);
    }
}
