using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Pets.Queries.GetPet
{
    public class GetPetQuery : IQuery<PetDto>
    {
        public Guid Id { get; set; }
    }
}
