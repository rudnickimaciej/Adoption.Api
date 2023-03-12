using Adoption.Application.Offerts.Commands.AddOffert;
using Adoption.Application.Offerts.Queries.GetOffert;
using Adoption.Application.Pets.Queries;
using Adoption.Infrastructure.Database;
using Adoption.Shared.Abstractions.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Adoption.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OffertsController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly SqlServerOptions _sqlServerOptions;
        //private readonly IQueryDispatcher _queryDistpatcher;
        private readonly IMediator _mediator;


        public OffertsController(
            ILogger<AuthController> logger, 
            //IQueryDispatcher queryDispatcher,
             IMediator mediator)
        {
            _logger = logger;
            //_queryDistpatcher = queryDispatcher;
            _mediator = mediator;
        }

        [HttpGet("{id:guid}")]
        //[Authorize]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {

            var offert = await _mediator.Send(new GetOffertQuery(id));
            //var result = await _queryDistpatcher.DispatchAsync<OffertDto>(query);
            return Ok(offert);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddOffertDto addOffert)
        {
            throw new NotImplementedException();
        }

        //[HttpPatch]
        //public async Task<IActionResult> Update(UpdateOffertDto updateOffert)
        //{
        //    throw new NotImplementedException();

        //}

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