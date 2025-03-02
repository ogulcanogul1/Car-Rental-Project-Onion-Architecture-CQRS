using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CarQueries;
using App.Domain.Entities.Cars;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.CarHandlers
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQueryRequest, GetCarByIdQueryResponse>
    {
        private readonly ICarRepository _repository;

        public GetCarByIdQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResponse> Handle(GetCarByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Car? car = await _repository.GetByIdAsync(request.Id);
            return new GetCarByIdQueryResponse
            {
                BigImageUrl = car.BigImageUrl,
                BrandId = car.BrandId,
                Fuel = car.Fuel,
                Id = car.Id,
                Km = car.Km,
                Luggage = car.Luggage,
                Model = car.Model,
                Seat = car.Seat,
                Transmisson = car.Transmisson,
                Year = car.Year
            };
        }

    }
}
