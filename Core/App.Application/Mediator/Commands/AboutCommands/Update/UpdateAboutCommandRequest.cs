using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.AboutCommands.Update
{
    public class UpdateAboutCommandRequest : IRequest
    {
        public About About { get; set; } = default!;
    }
}
