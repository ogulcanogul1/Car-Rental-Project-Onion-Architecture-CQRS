using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQueryRequest : IRequest<List<GetAuthorQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
