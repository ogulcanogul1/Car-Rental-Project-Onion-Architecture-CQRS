using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetDynamicBlogsWithAuthorQueryRequest : IRequest<List<GetDynamicBlogsWithAuthorQueryResponse>>
    {
        public bool IsFirst { get; set; }
        public int Count { get; set; }
    }
}
