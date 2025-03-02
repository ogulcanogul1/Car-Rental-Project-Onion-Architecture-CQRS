using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CommentQueries
{
    public class GetCommentQueryRequest : IRequest<List<GetCommentQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
