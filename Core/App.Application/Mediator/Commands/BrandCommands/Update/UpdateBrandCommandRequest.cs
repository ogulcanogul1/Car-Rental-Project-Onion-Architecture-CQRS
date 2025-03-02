using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.BrandCommands.Update
{
    public class UpdateBrandCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
