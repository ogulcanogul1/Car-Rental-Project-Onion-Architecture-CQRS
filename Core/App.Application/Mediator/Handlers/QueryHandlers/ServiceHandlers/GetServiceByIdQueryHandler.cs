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
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQueryRequest, GetServiceByIdQueryResponse>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResponse> Handle(GetServiceByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Service service = await _repository.GetByIdAsync(request.Id);
            if (service == null) { }

            return new()
            {
                Description = service.Description,
                Id = service.Id,
                IconUrl = service.IconUrl,
                Title = service.Title
            };
        }
    }
}
