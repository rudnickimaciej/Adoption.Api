namespace Adoption.Infrastructure.DTO
{
    internal class OffertModel
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public int Version { get; set; }
        public string Description { get; set; }
        public ICollection<ApplicationReadModel> Applications{ get; set; }
        public ApplicationReadModel? WonApplication { get; set; }
    }
    internal class OffertWriteModel
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public int Version { get; set; }
        public string Description { get; set; }
        public ICollection<ApplicationReadModel> Applications { get; set; }
        public ApplicationReadModel? WonApplication { get; set; }

    }
}
