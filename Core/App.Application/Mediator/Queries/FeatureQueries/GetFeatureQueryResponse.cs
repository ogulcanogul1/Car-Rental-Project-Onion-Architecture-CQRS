﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
