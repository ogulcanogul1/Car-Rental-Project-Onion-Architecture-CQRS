using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.BlogQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.BlogHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQueryRequest, List<GetBlogQueryResponse>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetBlogQueryResponse>> Handle(GetBlogQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.GetAll().Select(x => new GetBlogQueryResponse
            {
                Id = x.Id,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Comment = x.Comment,
                Title = x.Title,
            }).ToList());
        }
    }
}
