
using Adoption.Application.Offerts.DTO;
using Adoption.Auth.Authentication;
using Adoption.Infrastructure.EF.Options;
using Microsoft.AspNetCore.Mvc;
using OneOf;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OffertsController : ControllerBase
    {
        
        private readonly ILogger<AuthController> _logger;
        private readonly SqlServerOptions _sqlServerOptions;

        public OffertsController(
            ILogger<AuthController> logger, 
            SqlServerOptions sqlServerOptions)
        {
            _logger = logger;
            _sqlServerOptions = sqlServerOptions;
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid offertId)
        {
            throw new NotImplementedException();

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();

        }
        [HttpPost]
        public async Task<IActionResult> Add(AddOffertDto addApplication)
        {

            throw new NotImplementedException();

        }

        [HttpPatch]
        public async Task<IActionResult> Update(UpdateOffertDto updateApplication)
        {
            throw new NotImplementedException();

        }



    }
}