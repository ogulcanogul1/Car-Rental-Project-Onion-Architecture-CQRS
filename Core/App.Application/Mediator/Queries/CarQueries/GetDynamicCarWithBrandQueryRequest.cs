using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CarQueries
{
    public class GetDynamicCarWithBrandQueryRequest : IRequest<List<GetDynamicCarWithBrandQueryResponse>>
    {
        public bool IsTop { get; set; }
        public int Count { get; set; }
    }
}
