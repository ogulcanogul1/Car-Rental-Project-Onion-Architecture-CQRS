using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.LocationCommands.Create
{
    public class CreateLocationCommandRequest : IRequest<CreateLocationCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
