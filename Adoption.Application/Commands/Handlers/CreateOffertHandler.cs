using Adoption.Application.Exceptions;
using Adoption.Application.Services;
using Adoption.Domain.Aggregates;
using Adoption.Domain.Repositiories;
using Adoption.Shared.Abstractions.Command;
using Adoption.Domain.ValueObjects;

namespace Adoption.Application.Commands.Handlers
{
    public class CreateOffertHandler : ICommandHandler<CreateOffert>
    {
        private readonly IOffertReadService _offertReadService;
        private readonly IPetReadService _petReadService;

        private readonly IOffertRepository _offertRepository;

        public CreateOffertHandler(IOffertReadService offertReadService, IOffertRepository offertRepository)
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
