using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
