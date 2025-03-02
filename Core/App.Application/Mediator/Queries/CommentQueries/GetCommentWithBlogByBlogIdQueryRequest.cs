using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CommentQueries
{
    public class GetCommentWithBlogByBlogIdQueryRequest : IRequest<GetCommentWithBlogByBlogIdQueryResponse>
    {
        public GetCommentWithBlogByBlogIdQueryRequest(int blogId)
        {
            BlogId = blogId;
        }
        public int BlogId { get; set; }
    }
}
