using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetBlogQueryRequest : IRequest<List<GetBlogQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
