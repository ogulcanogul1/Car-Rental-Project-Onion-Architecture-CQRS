using App.Application.Interfaces.RepositoryInterfaces;
using App.Application.Mediator.Queries.BlogQueries;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.BlogHandlers;

public class GetDynamicBlogsWithAuthorQueryHandler : IRequestHandler<GetDynamicBlogsWithAuthorQueryRequest, List<GetDynamicBlogsWithAuthorQueryResponse>>
{
    private readonly IBlogRepository _repository;

    public GetDynamicBlogsWithAuthorQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

    public Task<List<GetDynamicBlogsWithAuthorQueryResponse>> Handle(GetDynamicBlogsWithAuthorQueryRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetDynamicBlogsWithAuthor(request.IsFirst, request.Count).Select(x => new GetDynamicBlogsWithAuthorQueryResponse
        {
            Id = x.Id,
            CoverImageUrl = x.CoverImageUrl,
            CreatedDate = x.CreatedDate,
            Comment = x.Comment,
            Title = x.Title,
            AuthorId = x.AuthorId,
            AuthorDescription = x.Author.Description,
            AuthorName = x.Author.Name,
            AuthorImageUrl = x.Author.ImageUrl
        }).ToList());
    }
}
