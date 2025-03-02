using App.Application.Interfaces;
using App.Application.Mediator.Commands.RentTypeCommands.Create;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.RentTypeHandlers
{
    public class CreateRentTypeCommandHandler : IRequestHandler<CreateRentTypeCommandRequest, CreateRentTypeCommandResponse>
    {
        private readonly IRepository<RentType> _repository;

        public CreateRentTypeCommandHandler(IRepository<RentType> repository)
        {
            _repository = repository;
        }

        public async Task<CreateRentTypeCommandResponse> Handle(CreateRentTypeCommandRequest request, CancellationToken cancellationToken)
        {
            RentType type = new()
            {
                Type = request.Type
            };
            await _repository.CreateAsync(type);

            return new() { Id = type.Id };  
        }
    }
}
