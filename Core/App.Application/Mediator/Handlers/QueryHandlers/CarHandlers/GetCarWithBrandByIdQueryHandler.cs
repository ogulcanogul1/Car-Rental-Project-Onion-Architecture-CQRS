using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CarQueries;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CarHandlers
{
    public class GetCarWithBrandByIdQueryHandler : IRequestHandler<GetCarWithBrandByIdQueryRequest, GetCarWithBrandByIdQueryResponse>
    {
        private readonly ICarRepository _repostiory;

        public GetCarWithBrandByIdQueryHandler(ICarRepository repostiory)
        {
            _repostiory = repostiory;
        }

        public async Task<GetCarWithBrandByIdQueryResponse> Handle(GetCarWithBrandByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Car car = await _repostiory.GetCarWithBrandAsync(request.Id);

            if (car == null)
            {

            }

            return new()
            {
                BigImageUrl = car.BigImageUrl,
                Id = car.Id,
                BrandId = car.BrandId,
                BrandName = car.Brand.Name,
                Fuel = car.Fuel,
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
