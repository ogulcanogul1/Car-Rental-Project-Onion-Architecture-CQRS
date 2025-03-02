using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.BlogCommands.Create
{
    public class CreateBlogCommandResponse
    {
        public CreateBlogCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}
