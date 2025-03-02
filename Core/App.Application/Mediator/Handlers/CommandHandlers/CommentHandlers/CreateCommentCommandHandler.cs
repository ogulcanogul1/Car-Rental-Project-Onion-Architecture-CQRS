using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.CommentCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.CommentHandlers
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommandRequest, CreateCommentCommandResponse>
    {
        private readonly ICommentRepository _commentRepository;

        public CreateCommentCommandHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            Comment comment = new Comment
            {
                BlogId = request.BlogId,
                CreatedDate = request.CreatedDate,
                Description = request.Description,
                Name = request.Name
            };

            await _commentRepository.CreateAsync(comment);

            return new(comment.Id);

        }
    }
}
