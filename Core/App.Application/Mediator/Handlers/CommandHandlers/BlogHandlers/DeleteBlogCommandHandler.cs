using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.BlogCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.BlogHandlers
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommandRequest>
    {
        private readonly IBlogRepository _repository;

        public DeleteBlogCommandHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBlogCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
