using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Queries;
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
    public class FeedsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public FeedsController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<FeedsController>
        [HttpGet]
        public async Task<ActionResult<List<FeedDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetFeedListRequest());
            return Ok(vaccines);
        }


        // GET api/<FeedsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FeedDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetFeedDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<FeedsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FeedDto feed)
        {
            var command = new CreateFeedCommand { FeedDto = feed };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<FeedsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateFeedDto feed)
        {
            var command = new UpdateFeedCommand { FeedDto = feed };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<FeedsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteFeedCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

