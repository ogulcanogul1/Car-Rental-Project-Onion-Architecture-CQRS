using App.Application.Interfaces;
using App.Application.Mediator.Commands.TagCloudCommands.Update;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommandRequest>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(new TagCloud
            {
                BlogId = request.BlogId,
                Id = request.Id,
                Title = request.Title
            }
            );
        }
    }
}
