using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQueryRequest : IRequest<List<GetTestimonialQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
