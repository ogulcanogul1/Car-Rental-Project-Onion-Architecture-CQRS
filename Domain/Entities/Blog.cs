using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? CoverImageUrl { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public Author Author { get; set; } = default!;
        public int AuthorId { get; set; }
        public Category Category { get; set; } = default!;
        public int CategoryId { get; set; }
        public List<TagCloud>? TagClouds { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
