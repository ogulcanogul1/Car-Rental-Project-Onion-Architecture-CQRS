using App.Application.Interfaces;
using App.Application.Mediator.Queries.TestimonialQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQueryRequest, GetTestimonialByIdQueryResponse>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResponse> Handle(GetTestimonialByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Testimonial? testimonial = await _repository.GetByIdAsync(request.Id);
            if (testimonial == null)
            {

            }

            return new()
            {
                Id = testimonial.Id,
                Name = testimonial.Name,
                Comment = testimonial.Comment,
                ImageUrl = testimonial.ImageUrl,
                Title = testimonial.Title
            };
        }
    }
}
