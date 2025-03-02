using App.Application.Interfaces;
using App.Application.Mediator.Commands.AuthorCommands.Update;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            Author author = new()
            {
                Id = request.Id,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name
            };
            await _repository.UpdateAsync(author);
        }
    }
}
