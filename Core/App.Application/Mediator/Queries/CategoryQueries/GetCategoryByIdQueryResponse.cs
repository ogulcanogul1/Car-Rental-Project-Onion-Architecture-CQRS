using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
