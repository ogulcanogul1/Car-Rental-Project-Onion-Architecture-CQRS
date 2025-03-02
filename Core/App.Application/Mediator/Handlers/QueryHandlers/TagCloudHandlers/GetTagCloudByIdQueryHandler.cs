using App.Application.Interfaces;
using App.Application.Mediator.Queries.TagCloudQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler : IRequestHandler<GetTagCloudByIdQueryRequest, GetTagCloudGetByIdQueryResponse>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudGetByIdQueryResponse> Handle(GetTagCloudByIdQueryRequest request, CancellationToken cancellationToken)
        {
            TagCloud? tagCloud = await _repository.GetByIdAsync(request.Id);

            if (tagCloud == null)
            {

            }

            return new()
            {
                Id = tagCloud.Id,
                BlogId = tagCloud.BlogId,
                Title = tagCloud.Title
            };
        }
    }
}
