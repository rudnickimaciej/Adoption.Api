namespace Adoption.Infrastructure.DTO
{
    internal class PetReadModel
    {
        public Guid Id { get; set; }
        string Name { get; set; }
        public DateTime Birthdate{ get; set; }
        public string Breed { get; set; }
    }
}
