using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CarQueries;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.CarHandlers
{
    public class GetDynamicCarWithBrandHandler : IRequestHandler<GetDynamicCarWithBrandQueryRequest, List<GetDynamicCarWithBrandQueryResponse>>
    {
        private readonly ICarRepository _carRepository;

        public GetDynamicCarWithBrandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Task<List<GetDynamicCarWithBrandQueryResponse>> Handle(GetDynamicCarWithBrandQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_carRepository.GetDynamicCarWithBrands(request.IsTop, request.Count).Select(x => new GetDynamicCarWithBrandQueryResponse
            {
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
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
