using App.Application.Interfaces;
using App.Application.Mediator.Commands.RentTypeCommands.Update;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.RentTypeHandlers
{
    public class UpdateRentTypeCommandHandler : IRequestHandler<UpdateRentTypeCommandRequest>
    {
        private readonly IRepository<RentType> _repository;

        public UpdateRentTypeCommandHandler(IRepository<RentType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateRentTypeCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(new()
            {
                 Id = request.Id,
                  Type = request.Type
            });

        }
    }
}
