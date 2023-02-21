using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.Services
{
    public interface IOffertReadService
    {
        Task<bool> ExistsByPetId(Guid petId);
    }
}
