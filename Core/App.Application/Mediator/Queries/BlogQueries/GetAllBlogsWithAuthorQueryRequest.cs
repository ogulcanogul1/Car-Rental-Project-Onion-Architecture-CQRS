using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorQueryRequest : IRequest<List<GetAllBlogsWithAuthorQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
