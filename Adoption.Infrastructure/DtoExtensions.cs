using Adoption.Application.Offerts.Queries.GetOffert;
using Adoption.Application.Queries.Commands.GetApplicationDetails;
using Adoption.Domain.Offerts.Aggregates;

namespace Adoption.Infrastructure
{
    internal static class Extensions
    {
        public static OffertDto AsDto(this Offert offert)
            => new()
            {
                Id = offert.Id,
                Description = offert.Description,
                PetId = offert.PetId.Value,

                Applications = offert.Applications?.Select(a => new ApplicationDetailsDto
                {
                    Id = a.Id,
                    ApplicantName = a.ApplicantName,
                    ApplicantLastName = a.ApplicantLastName
                })
            };
    }
}