using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CommentQueries
{
    public class GetCommentByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime CreatedDate { get; set; }
        public string? Description { get; set; }
        public int BlogId { get; set; }
    }
}
