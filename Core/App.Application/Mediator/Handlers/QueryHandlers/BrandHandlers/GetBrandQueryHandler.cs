using App.Application.Interfaces;
using App.Application.Mediator.Queries.BrandQueries;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQueryRequest, List<GetBrandQueryResponse>>
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public Task<List<GetBrandQueryResponse>> Handle(GetBrandQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new GetBrandQueryRequest() { Tracking = true };
            }

            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetBrandQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList());
        }
    }
}
