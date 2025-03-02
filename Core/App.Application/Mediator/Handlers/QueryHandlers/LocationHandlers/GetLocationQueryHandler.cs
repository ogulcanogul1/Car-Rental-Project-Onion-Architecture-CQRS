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
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQueryRequest, List<GetLocationQueryResponse>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public Task<List<GetLocationQueryResponse>> Handle(GetLocationQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new GetLocationQueryRequest() { Tracking = true };
            }
            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetLocationQueryResponse
            {
                Id = x.Id,
                Name = x.Name
            }).ToList());
        }
    }
}
