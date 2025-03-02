using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CarPriceQueries
{
    public class GetCarPriceByWeekQueryRequest : IRequest<List<GetCarPriceByWeekQueryResponse>>
    {
        public GetCarPriceByWeekQueryRequest(bool tracking)
        {
            Tracking = tracking;    
        }
        public bool Tracking { get; set; }
    }
}
