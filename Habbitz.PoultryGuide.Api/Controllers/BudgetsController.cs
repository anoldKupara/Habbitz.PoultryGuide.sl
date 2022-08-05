using Habbitz.PoultryGuide.Application.DTOs.Budgets;
using Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Queries;
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
    public class BudgetsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public BudgetsController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<BudgetsController>
        [HttpGet]
        public async Task<ActionResult<List<BudgetDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetBudgetListRequest());
            return Ok(vaccines);
        }


        // GET api/<BudgetsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BudgetDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetBudgetDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<BudgetsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BudgetDto budget)
        {
            var command = new CreateBudgetCommand { BudgetDto = budget };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<BudgetsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateBudgetDto budget)
        {
            var command = new UpdateBudgetCommand { BudgetDto = budget };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<BudgetsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteBudgetCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
