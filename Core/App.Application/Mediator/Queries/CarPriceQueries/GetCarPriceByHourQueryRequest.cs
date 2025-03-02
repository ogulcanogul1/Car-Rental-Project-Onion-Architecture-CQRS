using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CarPriceQueries
{
    public class GetCarPriceByHourQueryRequest : IRequest<List<GetCarPriceByHourQueryResponse>>
    {
        public GetCarPriceByHourQueryRequest(bool tracking)
        {
            tracking = Tracking;
        }
        public bool Tracking { get; set; }
    }
}
