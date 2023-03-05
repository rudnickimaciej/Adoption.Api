using Adoption.Application.Pets.Commands;
using Adoption.Application.Pets.DTO;
using Adoption.Infrastructure.EF.Options;
using Adoption.Shared.Abstractions.Command;
using Microsoft.AspNetCore.Mvc;
using OneOf;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly SqlServerOptions _sqlServerOptions;

        private readonly ICommandDispatcher _commandDispatcher;
        public PetsController(
            ILogger<AuthController> logger, 
            SqlServerOptions sqlServerOptions)
        {
            _logger = logger;
            _sqlServerOptions = sqlServerOptions;
        }
        [HttpGet]
        public async Task<IActionResult> Get(Guid petId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();

        }
        [HttpPost]
        public async Task<IActionResult> AddPetAsync(CreatePet command)
        {
          await _commandDispatcher.DispatchAsync<CreatePet>(command);
          return Ok();
        }

        [HttpPatch]
        public async Task<IActionResult> Update(UpdatePetDto updatePet)
        {
            throw new NotImplementedException();

        }

        [HttpPatch]
        public async Task<IActionResult> MarkAsAdopted(Guid petId)
        {
            throw new NotImplementedException();

        }
    }
}