using App.Application.Interfaces;
using App.Application.Mediator.Commands.TagCloudCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.TagCloudHandlers
{
    public class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommandRequest, CreateTagCloudCommandResponse>
    {
        private readonly IRepository<TagCloud> _repository;

        public CreateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<CreateTagCloudCommandResponse> Handle(CreateTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            TagCloud tagCloud = new TagCloud
            {
                Id = request.Id,
                BlogId = request.BlogId,
                Title = request.Title,
            };
            await _repository.CreateAsync(tagCloud);

            return new(request.Id);
        }
    }
}
