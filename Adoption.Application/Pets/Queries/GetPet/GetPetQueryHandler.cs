using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Pets.Queries.GetPet
{
    public class GetPetQueryHandler : IQueryHandler<GetPetQuery, PetDto>
    {
        public Task<PetDto> Handle(GetPetQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
