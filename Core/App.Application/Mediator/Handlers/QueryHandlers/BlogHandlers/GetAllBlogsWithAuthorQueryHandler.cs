using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.BlogQueries;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQueryRequest, List<GetAllBlogsWithAuthorQueryResponse>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetAllBlogsWithAuthorQueryResponse>> Handle(GetAllBlogsWithAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.GetAllBlogsWithAuthor(request.Tracking).Select(x => new GetAllBlogsWithAuthorQueryResponse
            {
                Id = x.Id,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
                Comment = x.Comment,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                AuthorId = x.AuthorId
            }).ToList());
        }
    }
}
