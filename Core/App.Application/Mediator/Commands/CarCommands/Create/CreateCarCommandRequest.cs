using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.CarCommands.Create
{
    public class CreateCarCommandRequest : IRequest<CreateCarCommandResponse>
    {
        public int BrandId { get; set; }
        public string Model { get; set; } = default!;
        public int Year { get; set; }
        public double Km { get; set; }
        public string Transmisson { get; set; } = default!;
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; } = default!;
        public string BigImageUrl { get; set; } = default!;
    }
}
