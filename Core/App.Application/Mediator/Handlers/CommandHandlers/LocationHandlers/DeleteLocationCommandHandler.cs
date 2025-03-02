using App.Application.Interfaces;
using App.Application.Mediator.Commands.LocationCommands.Delete;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.LocationHandlers
{
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommandRequest>
    {
        private readonly IRepository<Location> _repository;

        public DeleteLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteLocationCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
