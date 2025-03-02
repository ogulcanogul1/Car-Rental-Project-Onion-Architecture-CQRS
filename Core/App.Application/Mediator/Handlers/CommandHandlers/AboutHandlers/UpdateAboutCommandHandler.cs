using App.Application.Interfaces;
using App.Application.Mediator.Commands.AboutCommands.Update;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.AboutHandlers
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommandRequest>
    {
        private readonly IRepository<About> _repository;
        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.About);
        }

    }
}
