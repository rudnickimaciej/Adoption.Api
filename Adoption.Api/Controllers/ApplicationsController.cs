using Adoption.Application.Offerts.Commands.AddOffert;
using Adoption.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        //[HttpGet("{id:guid}")]
        //public async Task<IActionResult> Get([FromRoute] GetApplications query)
        //{
        //    throw new NotImplementedException();

        //}

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    throw new NotImplementedException();

        //}
        [HttpPost]
        public async Task<IActionResult> Add(AddOffertDto addApplication)
        {

            throw new NotImplementedException();

        }

        //[HttpPatch]
        //public async Task<IActionResult> Update(UpdateOffertDto updateApplication)
        //{
        //    throw new NotImplementedException();

        //}



    }
}