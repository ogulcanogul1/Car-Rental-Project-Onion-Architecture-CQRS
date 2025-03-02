using App.Application.Interfaces;
using App.Application.Mediator.Commands.ServiceCommands.Update;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommandRequest>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(new()
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Id = request.Id,
                Title = request.Title
            });
        }
    }
}
