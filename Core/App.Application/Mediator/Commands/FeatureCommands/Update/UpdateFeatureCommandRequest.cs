using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.FeatureCommands.Update
{
    public class UpdateFeatureCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
