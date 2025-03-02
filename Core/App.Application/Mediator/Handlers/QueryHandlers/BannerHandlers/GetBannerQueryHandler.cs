using App.Application.Interfaces;
using App.Application.Mediator.Queries.BannerQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.BannerHandlers
{
    public class GetBannerQueryHandler : IRequestHandler<GetBannerQueryRequest,List<GetBannerQueryResponse>>
    {
        private readonly IRepository<Banner> _repository;
        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public Task<List<GetBannerQueryResponse>> Handle(GetBannerQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new() { Tracking = true };
            }
            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetBannerQueryResponse
            {
                Description = x.Description,
                Id = x.Id,
                Title = x.Title,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl
            }).ToList());
        }
    }
}
