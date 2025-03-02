using App.Application.Interfaces;
using App.Application.Mediator.Commands.FeatureCommands.Create;
using App.Application.Mediator.Commands.FeatureCommands.Delete;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.FeautreHandlers
{
    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommandRequest, CreateFeatureCommandResponse>
    {
        private readonly IRepository<Feature> _repository;

        public CreateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<CreateFeatureCommandResponse> Handle(CreateFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            Feature feature = new() { Name = request.Name };
            await _repository.CreateAsync(feature);
            return new() { Id = feature.Id };
        }
    }
}
