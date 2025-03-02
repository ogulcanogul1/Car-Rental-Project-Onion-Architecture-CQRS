using App.Domain.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BrandQueries
{
    public class GetBrandQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
