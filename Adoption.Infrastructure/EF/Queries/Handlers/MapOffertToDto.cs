using Adoption.Application.DTO;
using Adoption.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Infrastructure.EF.Queries.Handlers
{
    internal static class MapOffertToDto
    {
        public static OffertDto AsDto(this OffertModel offert)
            => new()
            {
                Id = offert.Id,
                PetId = offert.PetId,
                Description = offert.Description,
                Applications = offert.Applications.Select(a => new ApplicationDto
                {
                    Id = a.Id
                })
            };
    }
}
