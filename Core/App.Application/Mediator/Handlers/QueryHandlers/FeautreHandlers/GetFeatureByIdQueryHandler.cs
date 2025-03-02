using App.Application.Interfaces;
using App.Application.Mediator.Queries.FeatureQueries;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.FeautreHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQueryRequest, GetFeatureByIdQueryResponse>
    {
        private readonly IRepository<Feature> _repository;
        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResponse> Handle(GetFeatureByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Feature feature = await _repository.GetByIdAsync(request.Id);

            if (feature == null)
            {
            }

            return new()
            {
                Id = feature.Id,
                Name = feature.Name
            };
        }
    }
}
