using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.BlogCommands.Update;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommandRequest>
    {
        private readonly IBlogRepository _repository;

        public UpdateBlogCommandHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            Blog blog = new()
            {
                CreatedDate = request.CreatedDate,
                Id = request.Id,
                CoverImageUrl = request.CoverImageUrl,
                Title = request.Title,
                Comment = request.Comment,
                CategoryId = request.CategoryId,
                AuthorId = request.AuthorId
            };

            await _repository.UpdateAsync(blog);
        }
    }
}
