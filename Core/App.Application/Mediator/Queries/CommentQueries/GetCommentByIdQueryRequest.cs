using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CommentQueries
{
    public class GetCommentByIdQueryRequest : IRequest<GetCommentByIdQueryResponse>
    {
        public GetCommentByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
