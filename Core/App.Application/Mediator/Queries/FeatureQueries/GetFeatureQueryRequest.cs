using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQueryRequest : IRequest<List<GetFeatureQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
