using App.Application.Interfaces;
using App.Application.Mediator.Commands.FeatureCommands.Update;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.FeautreHandlers
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommandRequest>
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(new()
            {
                Id = request.Id,
                Name = request.Name
            });
        }
    }
}
