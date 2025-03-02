using App.Application.Interfaces;
using App.Application.Mediator.Queries.AboutQueries;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.AboutHandllers
{
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQueryRequest, List<GetAboutQueryResponse>>
    {
        private readonly IRepository<About> _repository;
        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public Task<List<GetAboutQueryResponse>> Handle(GetAboutQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                request = new() { Tracking = true };

            IQueryable<About?> query = _repository.GetAll(request.Tracking);
            var result = query.Select(x => new GetAboutQueryResponse
            {
                Description = x.Description,
                Title = x.Title,
                Id = x.Id,
                ImageUrl = x.ImageUrl
            }).ToList();
            return Task.FromResult(result);
        }
    }
}
