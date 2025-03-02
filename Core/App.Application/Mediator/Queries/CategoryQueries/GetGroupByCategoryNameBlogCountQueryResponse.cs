using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CategoryQueries
{
    public class GetGroupByCategoryNameBlogCountQueryResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public int BlogCount { get; set; }
    }
}
