using App.Application.Interfaces;
using App.Application.Mediator.Queries.FooterAddressQueries;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQueryRequest, GetFooterAddressByIdQueryResponse>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResponse> Handle(GetFooterAddressByIdQueryRequest request, CancellationToken cancellationToken)
        {
            FooterAddress? result = await _repository.GetByIdAsync(request.Id);
            if(result ==null)
            {

            }

            return new()
            {
                Id = result.Id,
                Address = result.Address,
                Description = result.Description,
                Email = result.Email,
                PhoneNumber = result.PhoneNumber
            };
        }
    }
}
