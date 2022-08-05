using Habbitz.PoultryGuide.Application.DTOs.BirdCategories;
using Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Commands;
using Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Queries;
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
    public class BirdCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HabbitzDbContext _dbContext;
        public BirdCategoriesController(IMediator mediator, HabbitzDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        // GET: api/<BirdCategoriesController>
        [HttpGet]
        public async Task<ActionResult<List<BirdCategoryDto>>> Get()
        {
            var vaccines = await _mediator.Send(new GetBirdCategoryListRequest());
            return Ok(vaccines);
        }


        // GET api/<BirdCategoriesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BirdCategoryDto>> Get(int id)
        {
            var vaccine = await _mediator.Send(new GetBirdCategoryDetailRequest { Id = id });
            return Ok(vaccine);
        }

        // POST api/<BirdCategoriesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BirdCategoryDto birdCategory)
        {
            var command = new CreateBirdCategoryCommand { BirdCategoryDto = birdCategory };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<BirdCategoriesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateBirdCategoryDto birdCategory)
        {
            var command = new UpdateBirdCategoryCommand { BirdCategoryDto = birdCategory };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<BirdCategoriesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteBirdCategoryCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

