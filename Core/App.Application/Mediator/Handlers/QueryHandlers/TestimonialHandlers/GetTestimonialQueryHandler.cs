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
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQueryRequest, List<GetTestimonialQueryResponse>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public Task<List<GetTestimonialQueryResponse>> Handle(GetTestimonialQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                request = new GetTestimonialQueryRequest() { Tracking = true };

            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetTestimonialQueryResponse
            {
                Comment = x.Comment,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Title = x.Title
            }).ToList());
        }
    }
}
