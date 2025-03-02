using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.AboutCommands.Delete
{
    public class DeleteAboutCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
