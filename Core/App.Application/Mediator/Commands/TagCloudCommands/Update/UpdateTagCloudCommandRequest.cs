using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.TagCloudCommands.Update
{
    public class UpdateTagCloudCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public int BlogId { get; set; }
    }
}
