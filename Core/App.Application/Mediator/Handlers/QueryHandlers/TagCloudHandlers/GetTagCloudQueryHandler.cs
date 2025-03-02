using App.Application.Interfaces;
using App.Application.Mediator.Queries.TagCloudQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.TagCloudHandlers
{
    public class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQueryRequest, List<GetTagCloudQueryResponse>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public Task<List<GetTagCloudQueryResponse>> Handle(GetTagCloudQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.GetAll().Select(x => new GetTagCloudQueryResponse
            {
                Id = x.Id,
                BlogId = x.BlogId,
                Title = x.Title
            }).ToList());
        }
    }
}
