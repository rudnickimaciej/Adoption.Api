namespace Adoption.Infrastructure.DTO
{
    internal class ApplicationReadModel
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public OffertReadModel Offert { get; set; }
    }
}
