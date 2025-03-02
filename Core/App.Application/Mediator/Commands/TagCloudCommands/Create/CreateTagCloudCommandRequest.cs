using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.TagCloudCommands.Create
{
    public class CreateTagCloudCommandRequest : IRequest<CreateTagCloudCommandResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public int BlogId { get; set; }
    }
}
