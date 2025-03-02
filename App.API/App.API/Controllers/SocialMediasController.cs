using App.Application.Mediator.Commands.SocialMediaCommands.Create;
using App.Application.Mediator.Commands.SocialMediaCommands.Delete;
using App.Application.Mediator.Commands.SocialMediaCommands.Update;
using App.Application.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetSocialMediaQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetSocialMediaByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialMediaCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSocialMediaCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteSocialMediaCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }
    }
}
