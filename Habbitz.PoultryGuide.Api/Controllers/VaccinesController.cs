using Habbitz.PoultryGuide.Application.DTOs.Vaccines;
using Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Queries;
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
    public class VaccinesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public VaccinesController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<VaccinesController>
        [HttpGet]
        public async Task<ActionResult<List<VaccineDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetVaccineListRequest());
            return Ok(vaccines);
        }


        // GET api/<VaccinesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VaccineDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetVaccineDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<VaccinesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] VaccineDto vaccine)
        {
            var command = new CreateVaccineCommand { VaccineDto = vaccine };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<VaccinesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateVaccineDto vaccine)
        {
            var command = new UpdateVaccineCommand { VaccineDto = vaccine };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<VaccinesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteVaccineCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
