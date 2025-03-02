using App.Application.Interfaces;
using App.Application.Mediator.Commands.BannerCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.BannerHandlers
{
    public class DeleteBannerCommandHandler : IRequestHandler<DeleteBannerCommandRequest>
    {
        private readonly IRepository<Banner> _repository;
        public DeleteBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBannerCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }


    }
}
