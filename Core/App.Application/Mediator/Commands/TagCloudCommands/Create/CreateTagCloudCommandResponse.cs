using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.TagCloudCommands.Create
{
    public class CreateTagCloudCommandResponse
    {
        public CreateTagCloudCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
