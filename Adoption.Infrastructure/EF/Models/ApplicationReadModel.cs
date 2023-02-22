namespace Adoption.Infrastructure.DTO
{
    public class ApplicationReadModel
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public OffertReadModel Offert { get; set; }
    }
}
