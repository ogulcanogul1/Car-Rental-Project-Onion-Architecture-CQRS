using App.Application.Mediator.Commands.BrandCommands.Create;
using App.Application.Mediator.Commands.BrandCommands.Delete;
using App.Application.Mediator.Commands.BrandCommands.Update;
using App.Application.Mediator.Queries.BrandQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetBrandQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetBrandByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBrandCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteBrandCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }

    }
}
