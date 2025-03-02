using MediatR;

namespace App.Application.Mediator.Commands.BlogCommands.Update
{
    public class UpdateBlogCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? CoverImageUrl { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
