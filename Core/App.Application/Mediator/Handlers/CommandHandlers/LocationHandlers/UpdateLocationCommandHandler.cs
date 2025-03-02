using App.Application.Interfaces;
using App.Application.Mediator.Commands.LocationCommands.Update;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.LocationHandlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommandRequest>
    {
        private readonly IRepository<Location> _repository;

        public UpdateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommandRequest request, CancellationToken cancellationToken)
        {
            Location location = new Location { Id = request.Id, Name = request.Name };
            await _repository.UpdateAsync(location);
        }
    }
}
