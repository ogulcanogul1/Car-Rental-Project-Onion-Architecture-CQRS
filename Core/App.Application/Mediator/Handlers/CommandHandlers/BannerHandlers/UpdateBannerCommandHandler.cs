using App.Application.Interfaces;
using App.Application.Mediator.Commands.BannerCommands.Update;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.BannerHandlers
{
    public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommandRequest>
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.Banner);

        }
    }
}
