using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.CommentCommands.Delete
{
    public class DeleteCommentCommandRequest : IRequest
    {
        public DeleteCommentCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
