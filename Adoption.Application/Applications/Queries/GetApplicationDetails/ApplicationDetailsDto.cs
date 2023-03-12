namespace Adoption.Application.Queries.Commands.GetApplicationDetails
{
    public class ApplicationDetailsDto
    {
        public Guid Id { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantLastName { get; set; }
    }
}
