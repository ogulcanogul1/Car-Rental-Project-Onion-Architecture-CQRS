using App.Application.Interfaces;
using App.Application.Mediator.Queries.LocationQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQueryRequest, GetLocationByIdQueryResponse>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResponse> Handle(GetLocationByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Location? location = await _repository.GetByIdAsync(request.Id);
            if (location == null) 
            {

            }

            return new()
            {
                Id = location.Id,
                Name = location.Name
            };
        }
    }
}
