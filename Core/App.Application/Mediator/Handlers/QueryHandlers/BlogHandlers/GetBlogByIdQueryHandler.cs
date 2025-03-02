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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQueryRequest, GetBlogByIdQueryResponse>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResponse> Handle(GetBlogByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Blog? blog = await _repository.GetByIdAsync(request.Id);

            if (blog == null)
            {

            }

            return new()
            {
                Id = blog.Id,
                CoverImageUrl = blog.CoverImageUrl,
                Comment = blog.Comment,
                CreatedDate = blog.CreatedDate,
                Title = blog.Title
            };
        }
    }
}
