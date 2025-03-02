using App.Application.Mediator.Commands.BannerCommands.Create;
using App.Application.Mediator.Commands.BannerCommands.Delete;
using App.Application.Mediator.Commands.BannerCommands.Update;
using App.Application.Mediator.Queries.BannerQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BannersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetBannerQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetBannerByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteBannerCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }

    }
}
