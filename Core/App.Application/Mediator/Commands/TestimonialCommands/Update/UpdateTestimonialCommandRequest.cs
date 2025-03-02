using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.TestimonialCommands.Update
{
    public class UpdateTestimonialCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Comment { get; set; } = default!;
        public string? ImageUrl { get; set; }
    }
}
