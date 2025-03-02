using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.CommentCommands.Create
{
    public class CreateCommentCommandResponse
    {
        public CreateCommentCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
