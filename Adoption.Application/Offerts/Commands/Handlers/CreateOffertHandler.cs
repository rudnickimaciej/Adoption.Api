using Adoption.Shared.Abstractions.Command;
using Adoption.Application.Offerts.Services;
using Adoption.Application.Pets.Services;
using Adoption.Application.Offerts.Exceptions;
using Adoption.Domain.Offerts.Repositiories;
using Adoption.Domain.Offerts.Aggregates;
using Adoption.Domain.Offerts.ValueObjects;
using Adoption.Domain.Pets.ValueObjects;
namespace Adoption.Application.Commands.Handlers
{
    public class CreatePetHandler : ICommandHandler<CreateOffert>
    {
        private readonly IOffertReadService _offertReadService;
        private readonly IPetReadService _petReadService;

        private readonly IOffertRepository _offertRepository;

        public CreatePetHandler(IOffertReadService offertReadService, IOffertRepository offertRepository)
        {
            _offertReadService = offertReadService;
            _offertRepository = offertRepository;
        }

        public async Task HandleAsync(CreateOffert command)
        {
            var (PetId, Description) = command;

            if(!await _petReadService.ExistsById(PetId))
            {
                throw new PetNotExistsException(PetId);
            }

            if (await _offertReadService.ExistsByPetId(PetId))
            {
                throw new OffertWithPetIdAlreadyExistsException(PetId);
            }
            await _offertRepository.AddAsync(
                new Offert(new PetId(PetId),
                new OffertDescription(Description)));
        }
    }
}
