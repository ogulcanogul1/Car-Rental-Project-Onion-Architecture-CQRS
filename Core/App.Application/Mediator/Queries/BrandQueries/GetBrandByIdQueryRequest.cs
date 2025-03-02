using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BrandQueries
{
    public class GetBrandByIdQueryRequest : IRequest<GetBrandByIdQueryResponse>
    {
        public GetBrandByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
