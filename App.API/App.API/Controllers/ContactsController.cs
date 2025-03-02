using App.Application.Mediator.Commands.ContactCommands.Create;
using App.Application.Mediator.Commands.ContactCommands.Delete;
using App.Application.Mediator.Commands.ContactCommands.Update;
using App.Application.Mediator.Queries.ContactQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetContactQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetContactByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateContactCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteContactCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }

    }
}
