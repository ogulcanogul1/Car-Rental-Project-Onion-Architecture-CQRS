using App.Application.Interfaces;
using App.Application.Mediator.Queries.AboutQueries;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.AboutHandllers
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQueryRequest, GetAboutByIdQueryResponse>
    {
        private IRepository<About> _repository;
        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResponse> Handle(GetAboutByIdQueryRequest request, CancellationToken cancellationToken)
        {
            About? result = await _repository.GetByIdAsync(request.Id);

            return new GetAboutByIdQueryResponse
            {
                Id = result!.Id,
                Description = result.Description,
                ImageUrl = result.ImageUrl,
                Title = result.Title
            };
        }
    }
}
