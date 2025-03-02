using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetAuthorDetailByBlogIdQueryRequest : IRequest<GetAuthorDetailByBlogIdQueryResponse>
    {
        public GetAuthorDetailByBlogIdQueryRequest(int id)
        {
            Id = id;    
        }
        public int Id { get; set; }
    }
}
