using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CarQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CarHandlers
{
    public class GetCarsWithBrandQueryHandler : IRequestHandler<GetCarsWithBrandQueryRequest, List<GetCarsWithBrandQueryrResponse>>
    {
        private readonly ICarRepository _repository;

        public GetCarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetCarsWithBrandQueryrResponse>> Handle(GetCarsWithBrandQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.GetCarsWithBrandAsync(request.Tracking).Select(x => new GetCarsWithBrandQueryrResponse
            {
                Id = x.Id,
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,    
                BrandName = x.Brand.Name,
                Fuel = x.Fuel,
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
