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
    public class GetAuthorDetailByBlogIdQueryHandler : IRequestHandler<GetAuthorDetailByBlogIdQueryRequest, GetAuthorDetailByBlogIdQueryResponse>
    {
        private readonly IBlogRepository _blogRepository;

        public GetAuthorDetailByBlogIdQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<GetAuthorDetailByBlogIdQueryResponse> Handle(GetAuthorDetailByBlogIdQueryRequest request, CancellationToken cancellationToken)
        {
            Blog blog = await _blogRepository.GetAuthorDetailByBlogIdAsync(request.Id);

            if (blog == null)
            {

            }

            return new GetAuthorDetailByBlogIdQueryResponse()
            {
                AuthorDescription = blog.Author.Description,
                AuthorId = blog.Author.Id,
                AuthorName = blog.Author.Name,
                AuthorImageUrl = blog.Author.ImageUrl,
                BlogId = blog.Id,
            };
        }
    }
}
