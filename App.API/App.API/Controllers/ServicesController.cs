using App.Application.Mediator.Commands.ServiceCommands.Create;
using App.Application.Mediator.Commands.ServiceCommands.Delete;
using App.Application.Mediator.Commands.ServiceCommands.Update;
using App.Application.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetServiceQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetServiceByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateServiceCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteServiceCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }
    }
}
