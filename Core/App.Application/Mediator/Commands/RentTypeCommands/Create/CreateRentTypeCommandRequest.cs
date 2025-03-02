using App.Domain.Entities.Enumarations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.RentTypeCommands.Create
{
    public class CreateRentTypeCommandRequest : IRequest<CreateRentTypeCommandResponse>
    {
        public string Type { get; set; } = default!;

    }
}
