using Adoption.Domain.Pets.ValueObjects;

namespace Adoption.Domain.Pets.Entities
{
    public class Pet
    {
        public PetId Id { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }

        public DateTime Birthdate { get; set; }
        public string Description { get; set; }

        public Pet(PetId id, string name, Breed breed, DateTime birthdate, string description)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Birthdate = birthdate;
            Description = description;  
        }
    }
}
