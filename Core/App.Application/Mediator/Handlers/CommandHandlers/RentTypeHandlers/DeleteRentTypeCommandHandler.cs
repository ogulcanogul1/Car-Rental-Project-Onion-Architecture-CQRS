using App.Application.Interfaces;
using App.Application.Mediator.Commands.RentTypeCommands.Delete;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.RentTypeHandlers
{
    public class DeleteRentTypeCommandHandler : IRequestHandler<DeleteRentTypeCommandRequest>
    {
        private readonly IRepository<RentType> _repository;

        public DeleteRentTypeCommandHandler(IRepository<RentType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteRentTypeCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
