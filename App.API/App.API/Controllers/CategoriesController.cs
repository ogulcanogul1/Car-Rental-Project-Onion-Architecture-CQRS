using App.Application.Mediator.Commands.CategoryCommands.Create;
using App.Application.Mediator.Commands.CategoryCommands.Delete;
using App.Application.Mediator.Commands.CategoryCommands.Update;
using App.Application.Mediator.Queries.CategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetCategoryQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new GetCategoryByIdQueryRequest(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> Update(DeleteCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Kayıt Silindi");
        }

        

        [HttpGet("GroupByCategoryNameBlogCount")]
        public async Task<IActionResult> GetGroupByCategoryNameBlogCountQuery() => Ok(await _mediator.Send(new GetGroupByCategoryNameBlogCountQueryRequest()));


    }
}
