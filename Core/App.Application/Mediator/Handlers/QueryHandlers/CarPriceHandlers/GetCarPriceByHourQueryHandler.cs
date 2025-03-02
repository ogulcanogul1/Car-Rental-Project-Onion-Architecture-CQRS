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
    public class GetCarPriceByHourQueryHandler : IRequestHandler<GetCarPriceByHourQueryRequest, List<GetCarPriceByHourQueryResponse>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPriceByHourQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public Task<List<GetCarPriceByHourQueryResponse>> Handle(GetCarPriceByHourQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_carPricingRepository.GetCarPricingByTime(1).Select(x => new GetCarPriceByHourQueryResponse
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
