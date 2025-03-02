using App.Application.Mediator.Commands.AuthorCommands.Create;
using App.Application.Mediator.Commands.AuthorCommands.Delete;
using App.Application.Mediator.Commands.AuthorCommands.Update;
using App.Application.Mediator.Queries.AuthorQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetAuthorQueryRequest()));


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetAuthorByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAuthorCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteAuthorCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Silme işlemi başarılı");
        }
    }
}
