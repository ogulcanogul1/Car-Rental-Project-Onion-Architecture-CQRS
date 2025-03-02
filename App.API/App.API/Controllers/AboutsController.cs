using App.Application.Mediator.Commands.AboutCommands.Create;
using App.Application.Mediator.Commands.AboutCommands.Delete;
using App.Application.Mediator.Commands.AboutCommands.Update;
using App.Application.Mediator.Queries.AboutQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetAboutQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetAboutByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteAboutCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }



    }
}
