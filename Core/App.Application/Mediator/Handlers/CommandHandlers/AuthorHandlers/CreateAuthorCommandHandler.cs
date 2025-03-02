using App.Application.Interfaces;
using App.Application.Mediator.Commands.AuthorCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
    {
        private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            Author author = new()
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name
            };
            await _repository.CreateAsync(author);
            return new()
            {
                Id = author.Id
            };
        }
    }
}
