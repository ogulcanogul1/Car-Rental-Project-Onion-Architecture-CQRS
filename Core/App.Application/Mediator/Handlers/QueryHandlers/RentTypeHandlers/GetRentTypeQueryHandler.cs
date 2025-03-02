using App.Application.Interfaces;
using App.Application.Mediator.Queries.RentTypeQueries;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.RentTypeHandlers
{
    public class GetRentTypeQueryHandler : IRequestHandler<GetRentTypeQueryRequest, List<GetRentTypeQueryResponse>>
    {
        private readonly IRepository<RentType> _repository;

        public GetRentTypeQueryHandler(IRepository<RentType> repository)
        {
            _repository = repository;
        }

        public Task<List<GetRentTypeQueryResponse>> Handle(GetRentTypeQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                request = new GetRentTypeQueryRequest() { Tracking = true };

            return Task.FromResult(_repository.GetAll(tracking: request.Tracking).Select(x => new GetRentTypeQueryResponse
            {
                Id = x.Id,
                Type = x.Type
            }).ToList());
        }
    }
}
