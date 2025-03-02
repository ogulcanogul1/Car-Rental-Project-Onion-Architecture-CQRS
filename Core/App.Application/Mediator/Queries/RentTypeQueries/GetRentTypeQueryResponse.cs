using App.Domain.Entities.Enumarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.RentTypeQueries
{
    public class GetRentTypeQueryResponse
    {
        public int Id { get; set; }
        public string Type { get; set; } = default!;
    }
}
