using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CommentQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CommentHandlers
{
    public class GetCommentWithBlogByBlogIdQueryHandler : IRequestHandler<GetCommentWithBlogByBlogIdQueryRequest, GetCommentWithBlogByBlogIdQueryResponse>
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentWithBlogByBlogIdQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<GetCommentWithBlogByBlogIdQueryResponse> Handle(GetCommentWithBlogByBlogIdQueryRequest request, CancellationToken cancellationToken)
        {
            Comment comment = await _commentRepository.GetCommentWithBlogByBlogIdAsync(request.BlogId);

            if(comment == null)
            {
                return new();
            }

            return new()
            {
                BlogId = comment.BlogId,
                CreatedDate = comment.CreatedDate,
                Description = comment.Description,
                Id = comment.Id,
                Name = comment.Name
            };
        }
    }
}
