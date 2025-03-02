using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.CarCommands.Update;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.CarHandlers
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommandRequest>
    {

        private readonly ICarRepository _repository;

        public UpdateCarCommandHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car car = new Car
            {
                BigImageUrl = request.BigImageUrl,
                BrandId = request.BrandId,
                Fuel = request.Fuel,
                Id = request.Id,
                Km = request.Km,
                Luggage = request.Luggage,
                Model = request.Model,
                Seat = request.Seat,
                Transmisson = request.Transmisson,
                Year = request.Year
            };
            await _repository.UpdateAsync(car);
        }

    }
}
