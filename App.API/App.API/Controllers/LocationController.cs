using App.Application.Mediator.Commands.LocationCommands.Create;
using App.Application.Mediator.Commands.LocationCommands.Delete;
using App.Application.Mediator.Commands.LocationCommands.Update;
using App.Application.Mediator.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetLocationQueryRequest()));


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetLocationByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateLocationCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateLocationCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteLocationCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Silme işlemi başarılı");
        }
    }
}
