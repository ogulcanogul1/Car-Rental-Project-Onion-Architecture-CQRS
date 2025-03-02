using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.FeatureCommands.Create
{
    public class CreateFeatureCommandRequest : IRequest<CreateFeatureCommandResponse>
    {
        public string Name { get; set; } = default!;
    }
}
