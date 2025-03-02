using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Commands.CommentCommands.Update;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.CommentHandlers
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommandRequest>
    {
        private readonly ICommentRepository _commentRepository;

        public UpdateCommentCommandHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Handle(UpdateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            await _commentRepository.UpdateAsync(new()
            {
                BlogId = request.BlogId,
                CreatedDate = request.CreatedDate,
                Description = request.Description,
                Name = request.Name,
                Id = request.Id
            });
        }
    }
}
