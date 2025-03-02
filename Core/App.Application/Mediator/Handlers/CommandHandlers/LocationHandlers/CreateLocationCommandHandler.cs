using App.Application.Interfaces;
using App.Application.Mediator.Commands.LocationCommands.Create;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.LocationHandlers
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommandRequest, CreateLocationCommandResponse>
    {
        private readonly IRepository<Location> _repository;

        public CreateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<CreateLocationCommandResponse> Handle(CreateLocationCommandRequest request, CancellationToken cancellationToken)
        {
            Location location = new Location
            {
                Name = request.Name,
            };

            await _repository.CreateAsync(location);

            return new() {  Id = location.Id };
        }
    }
}
