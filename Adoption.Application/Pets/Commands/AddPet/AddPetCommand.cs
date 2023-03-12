using Adoption.Shared.Abstractions.Command;
using MediatR;

namespace Adoption.Application.Pets.Commands.AddPet
{
    public class  AddPetCommand : CommandBase<Unit>
    {
        public string Name { get; }
        public int Breed { get; }
        public DateTime Birthdate { get; }
        public string Description { get; }
        public AddPetCommand(string name, int breed, DateTime birthdate, string description)
        {
            Name = name;
            Breed = breed;
            Birthdate = birthdate;
            Description = description;
        }

        internal void Deconstruct(out string name, out int breed, out DateTime birthdate, out string description)
        {
            name = Name;
            breed = Breed;
            birthdate = Birthdate;
            description = Description;
        }
    }
}
