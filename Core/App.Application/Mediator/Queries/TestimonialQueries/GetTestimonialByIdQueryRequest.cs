using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQueryRequest : IRequest<GetTestimonialByIdQueryResponse>
    {
        public GetTestimonialByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
