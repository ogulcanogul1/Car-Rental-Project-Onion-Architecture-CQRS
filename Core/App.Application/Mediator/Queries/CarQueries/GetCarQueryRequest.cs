﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CarQueries
{
    public class GetCarQueryRequest : IRequest<List<GetCarQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
