using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQueryRequest : IRequest<List<GetCategoryQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
