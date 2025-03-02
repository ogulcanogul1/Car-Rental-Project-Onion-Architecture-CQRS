using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.CommentCommands.Delete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.CommentHandlers
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommandRequest>
    {
        private readonly ICommentRepository _commentRepository;

        public DeleteCommentCommandHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Handle(DeleteCommentCommandRequest request, CancellationToken cancellationToken)
        {
            await _commentRepository.DeleteAsync(request.Id);
        }
    }
}
