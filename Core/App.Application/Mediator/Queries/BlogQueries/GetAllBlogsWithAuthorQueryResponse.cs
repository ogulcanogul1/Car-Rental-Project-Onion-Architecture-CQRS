using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorQueryResponse
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = default!;
        public string? Comment { get; set; }
        public string? ShortComment 
        { 
            get 
            {
                if(Comment != null && Comment.Length > 150)
                {
                    return Comment.Substring(0,150) + "...";
                }

                return Comment;
            } 
        }
        public string? AuthorImageUrl { get; set; }
        public string? AuthorDescription { get; set; }
        public string Title { get; set; } = default!;
        public string? CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
