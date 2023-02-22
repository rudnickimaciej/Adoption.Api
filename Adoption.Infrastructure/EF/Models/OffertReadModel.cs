namespace Adoption.Infrastructure.DTO
{
    public class OffertReadModel
    {
        public Guid PetId { get; set; }
        public int Version { get; set; }
        public string Description { get; set; }
        public ICollection<ApplicationReadModel> Applications{ get; set; }
    }
}
