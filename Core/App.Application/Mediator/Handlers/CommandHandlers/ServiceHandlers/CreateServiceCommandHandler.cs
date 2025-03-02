using App.Application.Interfaces;
using App.Application.Mediator.Commands.ServiceCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommandRequest, CreateServiceCommandResponse>
    {
        private readonly IRepository<Service> _repository;

        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<CreateServiceCommandResponse> Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            Service service = new()
            {
                Description = request.Description,
                Title = request.Title,
                IconUrl = request.IconUrl
            };

            await _repository.CreateAsync(service);

            return new() { Id = service.Id };
        }
    }
}
