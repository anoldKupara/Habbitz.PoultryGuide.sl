using Habbitz.PoultryGuide.Application.DTOs.PaymentMethods;
using Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Queries;
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
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public PaymentMethodsController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<PaymentMethodsController>
        [HttpGet]
        public async Task<ActionResult<List<PaymentMethodDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetPaymentMethodListRequest());
            return Ok(vaccines);
        }


        // GET api/<PaymentMethodsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentMethodDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetPaymentMethodDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<PaymentMethodsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PaymentMethodDto paymentMethod)
        {
            var command = new CreatePaymentMethodCommand { PaymentMethodDto = paymentMethod};
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<PaymentMethodsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdatePaymentMethodDto paymentMethod)
        {
            var command = new UpdatePaymentMethodCommand { PaymentMethodDto = paymentMethod };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<PaymentMethodsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeletePaymentMethodCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

