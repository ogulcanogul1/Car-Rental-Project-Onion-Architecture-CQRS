using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryByIdQueryRequest : IRequest<GetCategoryByIdQueryResponse>
    {
        public GetCategoryByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
