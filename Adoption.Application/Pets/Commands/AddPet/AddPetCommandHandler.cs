using Adoption.Shared.Abstractions.Command;
using Adoption.Domain.Users.Repositiories;
using Adoption.Domain.Pets.Entities;
using Adoption.Domain.Pets.ValueObjects;
using MediatR;
using Adoption.Domain.Pets.Repositiories;

namespace Adoption.Application.Pets.Commands.AddPet
{
    public class CreatePetHandler : ICommandHandler<AddPetCommand,Unit>
    {
        private readonly IPetRepository _petRepository;


        public CreatePetHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

    

        public async Task<Unit> Handle(AddPetCommand command, CancellationToken cancellationToken)
        {
            var (name, breed, birthdate, description) = command;


            //if (await _offertReadService.ExistsByPetId(PetId))
            //{
            //    throw new OffertWithPetIdAlreadyExistsException(PetId);
            //}
             await _petRepository.AddAsync(
                new Pet(new PetId(Guid.NewGuid()), name, Breed.Spaniel, birthdate, description)); //it will always create Spanel
           
            return Unit.Value;
        }
    }
}
