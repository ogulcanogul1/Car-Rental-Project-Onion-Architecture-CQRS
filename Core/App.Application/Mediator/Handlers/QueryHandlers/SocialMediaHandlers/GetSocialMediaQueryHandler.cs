using App.Application.Interfaces;
using App.Application.Mediator.Queries.SocialMediaQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQueryRequest, List<GetSocialMediaQueryResponse>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public Task<List<GetSocialMediaQueryResponse>> Handle(GetSocialMediaQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                request = new GetSocialMediaQueryRequest() { Tracking = true };
            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetSocialMediaQueryResponse
            {
                Id = x.Id,
                IconUrl = x.IconUrl,
                Name = x.Name,
                Url = x.Url
            }).ToList());
        }
    }
}
