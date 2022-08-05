using Habbitz.PoultryGuide.Application.DTOs.Expenses;
using Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Queries;
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
    public class ExpensesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public ExpensesController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<ExpensesController>
        [HttpGet]
        public async Task<ActionResult<List<ExpenseDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetExpenseListRequest());
            return Ok(vaccines);
        }


        // GET api/<ExpensesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetExpenseDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<ExpensesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ExpenseDto feed)
        {
            var command = new CreateExpenseCommand { ExpenseDto = feed };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ExpensesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateExpenseDto feed)
        {
            var command = new UpdateExpenseCommand { ExpenseDto = feed };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<ExpensesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteExpenseCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
