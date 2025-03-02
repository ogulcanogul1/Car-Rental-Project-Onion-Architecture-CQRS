using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.CarCommands.Create;
using App.Domain.Entities.Cars;
using MediatR;


namespace App.Application.Mediator.Handlers.CommandHandlers.CarHandlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest, CreateCarCommandResponse>
    {
        private readonly ICarRepository _repository;

        public CreateCarCommandHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateCarCommandResponse> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car car = new()
            {
                BigImageUrl = request.BigImageUrl,
                BrandId = request.BrandId,
                Fuel = request.Fuel,
                Km = request.Km,
                Luggage = request.Luggage,
                Model = request.Model,
                Seat = request.Seat,
                Transmisson = request.Transmisson,
                Year = request.Year
            };
            await _repository.CreateAsync(car);

            return new(car.Id);
        }



    }
}
