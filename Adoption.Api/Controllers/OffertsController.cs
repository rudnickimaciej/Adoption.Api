using Adoption.Application.Offerts.DTO;
using Adoption.Infrastructure.EF.Options;
using Microsoft.AspNetCore.Mvc;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApplicationsController : ControllerBase
    {
        
        private readonly ILogger<AuthController> _logger;
        private readonly SqlServerOptions _sqlServerOptions;

        public ApplicationsController(
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
        public async Task<IActionResult> Add(AddOffertDto addOffert)
        {
            throw new NotImplementedException();


        }

        [HttpPatch]
        public async Task<IActionResult> Update(UpdateOffertDto updateOffert)
        {
            throw new NotImplementedException();

        }



        [HttpPatch("{offertId}/publish")]
        public async Task<IActionResult> Publish(Guid offertId)
        {
            throw new NotImplementedException();

        }

        [HttpPatch("{offertId}/unpublish")]
        public async Task<IActionResult> Unpublish(Guid offertId)
        {
            throw new NotImplementedException();

        }
        [HttpPatch("{offertId}/closewithadoption")]
        public async Task<IActionResult> CloseWithAdoption(Guid offertId)
        {
            throw new NotImplementedException();

        }
        [HttpPatch("{offertId}/closewithoutadoption")]
        public async Task<IActionResult> CloseWithoutAdoption(Guid offertId)
        {
            throw new NotImplementedException();

        }
    }
}