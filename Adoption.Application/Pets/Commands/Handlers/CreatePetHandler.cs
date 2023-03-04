using Adoption.Shared.Abstractions.Command;
using Adoption.Application.Offerts.Services;
using Adoption.Application.Pets.Services;
using Adoption.Domain.Users.Repositiories;
using Adoption.Domain.Pets.Entities;
using Adoption.Domain.Pets.ValueObjects;

namespace Adoption.Application.Pets.Commands.Handlers
{
    public class CreatePetHandler : ICommandHandler<CreatePet>
    {
        private readonly IPetRepository _petRepository;


        public CreatePetHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task HandleAsync(CreatePet command)
        {
            var (name, breed, birthdate, description) = command;


            //if (await _offertReadService.ExistsByPetId(PetId))
            //{
            //    throw new OffertWithPetIdAlreadyExistsException(PetId);
            //}
            await _petRepository.AddAsync(
                new Pet(new PetId(Guid.NewGuid()), name, Breed.Spaniel, birthdate, description)); //it will always create Spanel
        }
    }
}
