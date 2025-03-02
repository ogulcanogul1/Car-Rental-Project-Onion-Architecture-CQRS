using App.Application.Mediator.Commands.FooterAddressCommands.Create;
using App.Application.Mediator.Commands.FooterAddressCommands.Delete;
using App.Application.Mediator.Commands.FooterAddressCommands.Update;
using App.Application.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetFooterAddressQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetFooterAddressByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateFooterAddressCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFooterAddressCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(DeleteFooterAddressCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Kayıt Silindi");
        }

    }
}
