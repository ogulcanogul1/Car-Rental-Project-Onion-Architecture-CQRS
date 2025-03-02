using App.Application.Interfaces;
using App.Application.Mediator.Queries.AuthorQueries;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQueryRequest, GetAuthorByIdQueryResponse>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResponse> Handle(GetAuthorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Author? author = await _repository.GetByIdAsync(request.Id);
            
            if (author == null) { }

            return new()
            {
                Id = author.Id,
                Description = author.Description,
                ImageUrl = author.ImageUrl,
                Name = author.Name
            };
        }
    }
}
