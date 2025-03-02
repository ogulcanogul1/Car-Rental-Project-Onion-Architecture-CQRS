using App.Application.Interfaces;
using App.Application.Mediator.Queries.BannerQueries;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler : IRequestHandler<GetBannerByIdQueryRequest,GetBannerByIdQueryResponse>
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResponse> Handle(GetBannerByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Banner banner = await _repository.GetByIdAsync(request.Id);
            if (banner == null) 
            {

            }
            return new()
            {
                Description = banner.Description,
                Id = banner.Id,
                Title = banner.Title,
                VideoDescription = banner.VideoDescription,
                VideoUrl = banner.VideoUrl
            };
        }
    }
}
