using App.Application.Mediator.Commands.RentTypeCommands.Create;
using App.Application.Mediator.Commands.RentTypeCommands.Delete;
using App.Application.Mediator.Commands.RentTypeCommands.Update;
using App.Application.Mediator.Queries.RentTypeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetRentTypeQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetRentTypeByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateRentTypeCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateRentTypeCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteRentTypeCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }


    }
}
