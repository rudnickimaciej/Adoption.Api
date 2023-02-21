namespace Adoption.Application.Services
{
    public interface IPetReadService
    {
        Task<bool> ExistsById(Guid petId);
    }
}
