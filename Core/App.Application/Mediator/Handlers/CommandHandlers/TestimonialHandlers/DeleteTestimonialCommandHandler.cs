using App.Application.Interfaces;
using App.Application.Mediator.Commands.TestimonialCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.TestimonialHandlers
{
    public class DeleteTestimonialCommandHandler : IRequestHandler<DeleteTestimonialCommandRequest>
    {
        private readonly IRepository<Testimonial> _repository;

        public DeleteTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
