using App.Application.Mediator.Commands.SocialMediaCommands.Create;
using App.Application.Mediator.Commands.SocialMediaCommands.Delete;
using App.Application.Mediator.Commands.SocialMediaCommands.Update;
using App.Application.Mediator.Commands.TestimonialCommands.Create;
using App.Application.Mediator.Commands.TestimonialCommands.Delete;
using App.Application.Mediator.Commands.TestimonialCommands.Update;
using App.Application.Mediator.Queries.SocialMediaQueries;
using App.Application.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetTestimonialQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetTestimonialByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTestimonialCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteTestimonialCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }
    }
}
