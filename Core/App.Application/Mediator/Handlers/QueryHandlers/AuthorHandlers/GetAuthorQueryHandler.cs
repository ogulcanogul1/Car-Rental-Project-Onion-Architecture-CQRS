using App.Application.Interfaces;
using App.Application.Mediator.Queries.AuthorQueries;
using App.Domain.Entities;
using MediatR;


namespace App.Application.Mediator.Handlers.QueryHandlers.AuthorHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQueryRequest, List<GetAuthorQueryResponse>>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public Task<List<GetAuthorQueryResponse>> Handle(GetAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new() { Tracking = true };
            }
            return Task.FromResult(_repository.GetAll().Select(x => new GetAuthorQueryResponse
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).ToList());
        }
    }
}
