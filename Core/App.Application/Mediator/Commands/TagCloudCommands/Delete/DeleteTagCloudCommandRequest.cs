using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.TagCloudCommands.Delete
{
    public class DeleteTagCloudCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
