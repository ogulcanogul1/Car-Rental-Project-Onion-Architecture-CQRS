using App.Application.Interfaces;
using App.Application.Mediator.Commands.AboutCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.AboutHandlers
{
    public class DeleteAboutCommandHandler :IRequestHandler<DeleteAboutCommandRequest>
    {
        private readonly IRepository<About> _repository;
        public DeleteAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
