using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.CarCommands.Delete;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.CarHandlers
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommandRequest>
    {
        private readonly ICarRepository _repository;

        public DeleteCarCommandHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteCarCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }


    }
}
