using App.Application.Interfaces;
using App.Application.Mediator.Commands.TagCloudCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.TagCloudHandlers
{
    public class DeleteTagCloudCommandHandler : IRequestHandler<DeleteTagCloudCommandRequest>
    {
        private readonly IRepository<TagCloud> _repository;

        public DeleteTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
