using App.Application.Mediator.Commands.BlogCommands.Create;
using App.Application.Mediator.Commands.BlogCommands.Delete;
using App.Application.Mediator.Commands.BlogCommands.Update;
using App.Application.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetBlogQueryRequest()));


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetBlogByIdQueryRequest(id)));

        [HttpGet("GetAllBlogsWithAuthor")]
        public async Task<IActionResult> GetAllBlogsWithAuthor() => Ok(await _mediator.Send(new GetAllBlogsWithAuthorQueryRequest()));

        [HttpGet("GetDynamicAllBlogsWithAuthor")]
        public async Task<IActionResult> GetDynamicBlogsWithAuthor([FromQuery]GetDynamicBlogsWithAuthorQueryRequest request) => Ok(await _mediator.Send(request));

        [HttpGet("GetBlogWithAuthor/{blogId}")]
        public async Task<IActionResult> GetAuthorDetailByBlogId(int blogId) => Ok(await _mediator.Send(new GetAuthorDetailByBlogIdQueryRequest(blogId)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBlogCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteBlogCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Silme işlemi başarılı");
        }
    }
}
