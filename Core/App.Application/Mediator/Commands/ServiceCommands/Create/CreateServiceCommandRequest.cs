using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.ServiceCommands.Create
{
    public class CreateServiceCommandRequest : IRequest<CreateServiceCommandResponse>
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? IconUrl { get; set; } = default!;
    }
}
