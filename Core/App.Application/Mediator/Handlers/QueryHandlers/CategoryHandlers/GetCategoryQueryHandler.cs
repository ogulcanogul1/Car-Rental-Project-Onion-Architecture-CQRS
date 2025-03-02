using App.Application.Interfaces;
using App.Application.Mediator.Queries.CategoryQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, List<GetCategoryQueryResponse>>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }



        public Task<List<GetCategoryQueryResponse>> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new() { Tracking = true };
            }
            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetCategoryQueryResponse
            {
                Id = x.Id,
                Name = x.Name
            }).ToList());
        }
    }
}
