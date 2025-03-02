using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.TestimonialCommands.Create
{
    public class CreateTestimonialCommandResponse
    {
        public CreateTestimonialCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
