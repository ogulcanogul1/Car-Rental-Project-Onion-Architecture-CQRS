using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQueryRequest : IRequest<GetFeatureByIdQueryResponse>
    {
        public GetFeatureByIdQueryRequest(int id)
        {
            Id = id;    
        }
        public int Id { get; set; }

    }
}
