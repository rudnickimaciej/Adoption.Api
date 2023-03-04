namespace Adoption.Application.Pets.Services
{
    public interface IPetReadService
    {
        Task<bool> ExistsById(Guid petId);
    }
}
