using App.Application.Interfaces;
using App.Application.Mediator.Queries.RentTypeQueries;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.RentTypeHandlers
{
    public class GetRentTypeByIdQueryHandler : IRequestHandler<GetRentTypeByIdQueryRequest, GetRentTypeByIdQueryResponse>
    {
        private readonly IRepository<RentType> _repository;

        public GetRentTypeByIdQueryHandler(IRepository<RentType> repository)
        {
            _repository = repository;
        }

        public async Task<GetRentTypeByIdQueryResponse> Handle(GetRentTypeByIdQueryRequest request, CancellationToken cancellationToken)
        {
            RentType? type = await _repository.GetByIdAsync(request.Id);

            if (type == null) { }

            return new()
            {
                Id = type.Id,
                Type = type.Type
            };
        }
    }
}
