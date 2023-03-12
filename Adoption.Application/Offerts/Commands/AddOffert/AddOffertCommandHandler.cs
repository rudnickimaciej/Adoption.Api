using Adoption.Shared.Abstractions.Command;
using Adoption.Application.Offerts.Services;
using Adoption.Application.Offerts.Exceptions;
using Adoption.Domain.Offerts.Repositiories;
using Adoption.Domain.Offerts.Aggregates;
using Adoption.Domain.Offerts.ValueObjects;
using Adoption.Domain.Pets.ValueObjects;
using MediatR;
using Adoption.Domain.Users.Repositiories;
using Adoption.Domain.Pets.Repositiories;

namespace Adoption.Application.Offerts.Commands.AddOffert
{
    public class CreatePetHandler : ICommandHandler<AddOffertCommand, Unit>
    {
        private readonly IOffertService _offertReadService;
        private readonly IPetRepository _petRepository;
        private readonly IOffertRepository _offertRepository;

        public CreatePetHandler(IOffertService offertReadService, IOffertRepository offertRepository, IPetRepository _petRepository)
        {
            _offertReadService = offertReadService;
            _offertRepository = offertRepository;
        }


        public async Task<Unit> Handle(AddOffertCommand command, CancellationToken cancellationToken)
        {
            await _offertRepository.AddAsync(new Offert(new PetId(Guid.NewGuid()), "Opis"));

            var PetId = command.PetId;
            var Description = command.Description;


            if (await _petRepository.GetAsync(command.PetId) == null)
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

            return Unit.Value;
        }
    }
}
