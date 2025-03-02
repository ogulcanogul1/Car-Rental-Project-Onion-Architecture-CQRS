using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CarQueries;
using App.Domain.Entities.Cars;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.CarHandlers
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQueryRequest, List<GetCarQueryResponse>>
    {

        private readonly ICarRepository _repository;

        public GetCarQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetCarQueryResponse>> Handle(GetCarQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new GetCarQueryRequest() { Tracking = true };
            }

            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetCarQueryResponse
            {
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,
                Fuel = x.Fuel,
                Id = x.Id,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmisson = x.Transmisson,
                Year = x.Year
            }).ToList());
        }
    }
}
