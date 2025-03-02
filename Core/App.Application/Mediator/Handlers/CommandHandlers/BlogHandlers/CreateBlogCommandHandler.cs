using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.BlogCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommandRequest, CreateBlogCommandResponse>
    {
        private readonly IBlogRepository _repository;

        public CreateBlogCommandHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateBlogCommandResponse> Handle(CreateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            Blog blog = new()
            {
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
                Title = request.Title,
                AuthorId = request.AuthorId,
                CategoryId = request.CategoryId,
                Comment = request.Comment
            };
            await _repository.CreateAsync(blog);

            return new(blog.Id);
        }
    }
}
