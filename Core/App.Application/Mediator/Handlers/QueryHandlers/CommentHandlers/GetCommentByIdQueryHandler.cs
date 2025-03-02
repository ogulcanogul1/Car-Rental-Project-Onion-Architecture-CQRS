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
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQueryRequest, GetCommentByIdQueryResponse>
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentByIdQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<GetCommentByIdQueryResponse> Handle(GetCommentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Comment comment = await _commentRepository.GetByIdAsync(request.Id);

            return new()
            {
                Id = comment.Id,
                BlogId = comment.BlogId,
                CreatedDate = comment.CreatedDate,
                Description = comment.Description,
                Name = comment.Name
            };
        }
    }
}
