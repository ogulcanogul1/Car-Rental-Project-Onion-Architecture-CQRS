﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQueryRequest : IRequest<List<GetTagCloudQueryResponse>>
    {
    }
}
