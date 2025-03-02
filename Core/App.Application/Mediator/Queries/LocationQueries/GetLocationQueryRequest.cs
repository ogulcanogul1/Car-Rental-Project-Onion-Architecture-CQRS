﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.LocationQueries
{
    public class GetLocationQueryRequest : IRequest<List<GetLocationQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
