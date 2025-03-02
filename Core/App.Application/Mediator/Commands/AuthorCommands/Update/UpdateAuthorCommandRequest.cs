using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.AuthorCommands.Update
{
    public class UpdateAuthorCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
