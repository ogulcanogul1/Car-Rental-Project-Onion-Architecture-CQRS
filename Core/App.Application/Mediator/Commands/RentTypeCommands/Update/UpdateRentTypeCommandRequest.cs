using App.Domain.Entities.Enumarations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.RentTypeCommands.Update
{
    public class UpdateRentTypeCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Type { get; set; } = default!;

    }
}
