using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetAuthorDetailByBlogIdQueryResponse
    {
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = default!;
        public string? AuthorImageUrl { get; set; }
        public string? AuthorDescription { get; set; }
    }
}
