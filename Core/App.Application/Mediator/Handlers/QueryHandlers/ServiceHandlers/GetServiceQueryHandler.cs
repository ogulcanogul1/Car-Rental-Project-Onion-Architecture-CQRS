using App.Application.Interfaces;
using App.Application.Mediator.Queries.ServiceQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQueryRequest, List<GetServiceQueryResponse>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public Task<List<GetServiceQueryResponse>> Handle(GetServiceQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                request = new GetServiceQueryRequest() { Tracking = true };

            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetServiceQueryResponse
            {
                Description = x.Description,
                Id = x.Id,
                IconUrl = x.IconUrl,
                Title = x.Title
            }).ToList());
        }
    }
}
