﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQueryRequest : IRequest<GetServiceByIdQueryResponse>
    {
        public GetServiceByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
