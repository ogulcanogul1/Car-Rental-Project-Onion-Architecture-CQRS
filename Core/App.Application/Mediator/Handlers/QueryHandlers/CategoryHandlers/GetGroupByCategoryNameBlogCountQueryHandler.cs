using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CategoryQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CategoryHandlers
{
    internal class GetGroupByCategoryNameBlogCountQueryHandler : IRequestHandler<GetGroupByCategoryNameBlogCountQueryRequest, List<GetGroupByCategoryNameBlogCountQueryResponse>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetGroupByCategoryNameBlogCountQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<List<GetGroupByCategoryNameBlogCountQueryResponse>> Handle(GetGroupByCategoryNameBlogCountQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_categoryRepository.GetGroupByCategoryNameBlogCount().Select(x => new GetGroupByCategoryNameBlogCountQueryResponse
            {
                BlogCount = x.BlogCount,
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId
            }).ToList());
        }
    }
}
