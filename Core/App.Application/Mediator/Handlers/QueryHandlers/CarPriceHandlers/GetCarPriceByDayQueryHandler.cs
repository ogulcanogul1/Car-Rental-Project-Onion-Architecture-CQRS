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
    public class GetCarPriceByDayQueryHandler : IRequestHandler<GetCarPriceByDayQueryRequest, List<GetCarPriceByDayQueryResponse>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPriceByDayQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public Task<List<GetCarPriceByDayQueryResponse>> Handle(GetCarPriceByDayQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_carPricingRepository.GetCarPricingByTime(2).Select(x => new GetCarPriceByDayQueryResponse
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
