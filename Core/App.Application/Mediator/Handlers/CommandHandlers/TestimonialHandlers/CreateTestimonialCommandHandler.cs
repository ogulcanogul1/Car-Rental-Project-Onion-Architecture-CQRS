using App.Application.Interfaces;
using App.Application.Mediator.Commands.TestimonialCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommandRequest, CreateTestimonialCommandResponse>
    {
        private readonly IRepository<Testimonial> _repository;

        public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<CreateTestimonialCommandResponse> Handle(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            Testimonial testimonial = new Testimonial
            {
                Comment = request.Comment,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Title = request.Title
            };
            await _repository.CreateAsync(testimonial);
            return new(testimonial.Id); 
        }
    }
}
