using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CarPriceQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CarPriceHandlers
{
    public class GetCarPriceByWeekQueryHandler : IRequestHandler<GetCarPriceByWeekQueryRequest, List<GetCarPriceByWeekQueryResponse>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPriceByWeekQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public Task<List<GetCarPriceByWeekQueryResponse>> Handle(GetCarPriceByWeekQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_carPricingRepository.GetCarPricingByTime(3).Select(x => new GetCarPriceByWeekQueryResponse
            {
                Amount = x.Amount,
                BigImageUrl = x.Car.BigImageUrl,
                BrandName = x.Car.Brand.Name,
                Model = x.Car.Model,
                Year = x.Car.Year,
                Type = x.RentType.Type,
                BrandId = x.Car.BrandId,
                CarId = x.Car.BrandId,
                Id = x.Car.Id
            }).ToList());
        }
    }
}
