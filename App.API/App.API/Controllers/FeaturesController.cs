using App.Application.Mediator.Commands.FeatureCommands.Create;
using App.Application.Mediator.Commands.FeatureCommands.Delete;
using App.Application.Mediator.Commands.FeatureCommands.Update;
using App.Application.Mediator.Queries.FeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetFeatureQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetFeatureByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureCommandRequest command) => Ok(await _mediator.Send(command));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteFeatureCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Silme işlemi başarılı");
        }
    }
}
