using App.Application.Mediator.Commands.CarCommands.Create;
using App.Application.Mediator.Commands.CarCommands.Delete;
using App.Application.Mediator.Commands.CarCommands.Update;
using App.Application.Mediator.Queries.CarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetCarQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetCarByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCarCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteCarCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }

        [HttpGet("WithBrand")]
        public async Task<IActionResult> GetCarsWithBrand() => Ok(await _mediator.Send(new GetCarsWithBrandQueryRequest()));

        [HttpGet("WithBrand/{id}")]
        public async Task<IActionResult> GetCarsWithBrand(int id) => Ok(await _mediator.Send(new GetCarWithBrandByIdQueryRequest(id)));

        [HttpGet("WithBrandDescending")]
        public async Task<IActionResult> GetDynamicCarWithBrand([FromQuery]GetDynamicCarWithBrandQueryRequest request) => Ok(await _mediator.Send(request));
 
        

    }
}
