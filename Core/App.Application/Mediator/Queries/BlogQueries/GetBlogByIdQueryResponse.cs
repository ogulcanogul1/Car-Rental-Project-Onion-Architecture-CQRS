using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Comment { get; set; }
        public string? CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
