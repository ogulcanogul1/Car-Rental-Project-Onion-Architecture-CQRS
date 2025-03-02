using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.LocationQueries
{
    public class GetLocationByIdQueryRequest : IRequest<GetLocationByIdQueryResponse>
    {
        public GetLocationByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
