using Habbitz.PoultryGuide.Application.DTOs.Sales;
using Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Sales.Requests.Queries;
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
    public class SalesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public SalesController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<SalesController>
        [HttpGet]
        public async Task<ActionResult<List<SaleDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetSaleListRequest());
            return Ok(vaccines);
        }


        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetSaleDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<SalesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SaleDto sale)
        {
            var command = new CreateSaleCommand { SaleDto = sale };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateSaleDto sale)
        {
            var command = new UpdateSaleCommand { SaleDto = sale };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteSaleCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
