using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.BannerCommands.Create
{
    public class CreateBannerCommandResponse
    {
        public CreateBannerCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
