using App.Domain.Entities;
using System.Net;

namespace App.Dtos.BlogDtos;

public class BlogResponseDto
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; } = default!;
    public string ShortComment { get; set; } = default!;
    public string? AuthorImageUrl { get; set; }
    public string? AuthorDescription { get; set; } 
    public string Title { get; set; } = default!;
    public string? CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
}
