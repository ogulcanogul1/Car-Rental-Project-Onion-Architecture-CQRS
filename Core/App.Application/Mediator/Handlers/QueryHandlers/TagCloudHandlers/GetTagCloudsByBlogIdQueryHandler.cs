using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.TagCloudQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.TagCloudHandlers
{
    public class GetTagCloudsByBlogIdQueryHandler : IRequestHandler<GetTagCloudsByBlogIdQueryRequest, List<GetTagCloudsByBlogIdQueryResponse>>
    {
        private readonly ITagCloudRepository _tagCloudRepository;

        public GetTagCloudsByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository)
        {
            _tagCloudRepository = tagCloudRepository;
        }

        public Task<List<GetTagCloudsByBlogIdQueryResponse>> Handle(GetTagCloudsByBlogIdQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_tagCloudRepository.GetTagCloudByBlogId(request.Id).Select(x => new GetTagCloudsByBlogIdQueryResponse
            {
                Id = x.Id,
                BlogId = x.BlogId,
                Title = x.Title
            }).ToList());
        }
    }
}
