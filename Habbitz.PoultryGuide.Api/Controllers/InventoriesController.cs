using Habbitz.PoultryGuide.Application.DTOs.Inventories;
using Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Queries;
using Habbitz.PoultryGuide.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Habbitz.PoultryGuide.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public InventoriesController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<InventoriesController>
        [HttpGet]
        public async Task<ActionResult<List<InventoryDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetInventoryListRequest());
            return Ok(vaccines);
        }


        // GET api/<InventoriesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetInventoryDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<InventoriesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] InventoryDto inventory)
        {
            var command = new CreateInventoryCommand { InventoryDto = inventory };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<InventoriesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateInventoryDto inventory)
        {
            var command = new UpdateInventoryCommand { InventoryDto = inventory };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<InventoriesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteInventoryCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
