using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.RentTypeQueries
{
    public class GetRentTypeQueryRequest : IRequest<List<GetRentTypeQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
