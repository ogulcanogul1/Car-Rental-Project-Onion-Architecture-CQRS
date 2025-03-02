using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.CarCommands.Create
{
    public class CreateCarCommandResponse
    {
        public CreateCarCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}
