using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BrandQueries
{
    public class GetBrandQueryRequest : IRequest<List<GetBrandQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
