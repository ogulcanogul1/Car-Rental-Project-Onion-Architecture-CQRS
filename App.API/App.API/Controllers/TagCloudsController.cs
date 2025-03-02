using App.Application.Mediator.Commands.TagCloudCommands.Create;
using App.Application.Mediator.Commands.TagCloudCommands.Delete;
using App.Application.Mediator.Commands.TagCloudCommands.Update;
using App.Application.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetTagCloudQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetTagCloudByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateTagCloudCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTagCloudCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteTagCloudCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }

        [HttpGet("TagCloudsByBlogId/{blogId}")]
        public async Task<IActionResult> GetTagCloudsByBlogId(int blogId) => Ok(await _mediator.Send(new GetTagCloudsByBlogIdQueryRequest(blogId)));
    }
}
