using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.CommentQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CommentHandlers
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQueryRequest, List<GetCommentQueryResponse>>
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Task<List<GetCommentQueryResponse>> Handle(GetCommentQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_commentRepository.GetAll().Select(x => new GetCommentQueryResponse
            {
                BlogId = x.Id,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name
            }).ToList());
        }
    }
}
