using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.CommentCommands.Create
{
    public class CreateCommentCommandRequest : IRequest<CreateCommentCommandResponse>
    {
        public string Name { get; set; } = default!;
        public DateTime CreatedDate { get; set; }
        public string? Description { get; set; }
        public int BlogId { get; set; }
    }
}
