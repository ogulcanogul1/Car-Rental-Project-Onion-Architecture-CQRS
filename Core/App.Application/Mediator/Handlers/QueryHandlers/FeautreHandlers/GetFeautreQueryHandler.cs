using App.Application.Interfaces;
using App.Application.Mediator.Queries.FeatureQueries;
using App.Domain.Entities.Cars;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.FeautreHandlers
{
    public class GetFeautreQueryHandler : IRequestHandler<GetFeatureQueryRequest, List<GetFeatureQueryResponse>>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeautreQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public Task<List<GetFeatureQueryResponse>> Handle(GetFeatureQueryRequest? request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new GetFeatureQueryRequest() { Tracking = true };
            }
            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetFeatureQueryResponse
            {
                Id = x.Id,
                Name = x.Name
            }).ToList());
        }
    }
}
