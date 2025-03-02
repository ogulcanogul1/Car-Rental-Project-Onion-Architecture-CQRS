using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CarPriceQueries
{
    public class GetCarPriceByDayQueryRequest : IRequest<List<GetCarPriceByDayQueryResponse>>
    {
        public GetCarPriceByDayQueryRequest(bool tracking)
        {
            Tracking = tracking;    
        }
        public bool Tracking { get; set; }
    }
}
