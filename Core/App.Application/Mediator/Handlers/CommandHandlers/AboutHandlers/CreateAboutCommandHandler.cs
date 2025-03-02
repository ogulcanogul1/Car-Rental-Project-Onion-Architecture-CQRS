using App.Application.Interfaces;
using App.Application.Mediator.Commands.AboutCommands.Create;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
    {
        private readonly IRepository<About> _repository;
        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            About about = new About
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Title = request.Title
            };
            await _repository.CreateAsync(about);

            return new(about.Id);
        }
    }
}
