using Habbitz.PoultryGuide.Application.DTOs.Currencies;
using Habbitz.PoultryGuide.Application.Features.Currencies.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Currencies.Requests.Queries;
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
    public class CurrenciesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public CurrenciesController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<CurrenciesController>
        [HttpGet]
        public async Task<ActionResult<List<CurrencyDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetCurrencyListRequest());
            return Ok(vaccines);
        }


        // GET api/<CurrenciesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurrencyDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetCurrencyDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<CurrenciesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CurrencyDto currency)
        {
            var command = new CreateCurrencyCommand { CurrencyDto = currency };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<CurrenciesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateCurrencyDto currency)
        {
            var command = new UpdateCurrencyCommand { CurrencyDto = currency };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<CurrenciesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCurrencyCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

