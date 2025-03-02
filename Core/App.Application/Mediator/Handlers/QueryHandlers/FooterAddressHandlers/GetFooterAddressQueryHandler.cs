using App.Application.Interfaces;
using App.Application.Mediator.Queries.FooterAddressQueries;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.QueryHandlers.FooterAddressHandlers;

public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQueryRequest, List<GetFooterAddressQueryResponse>>
{
    private readonly IRepository<FooterAddress> _repository;

    public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public Task<List<GetFooterAddressQueryResponse>> Handle(GetFooterAddressQueryRequest? request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            request = new GetFooterAddressQueryRequest() { Tracking = true };
        }

        return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetFooterAddressQueryResponse
        {
            Address = x.Address,
            Description = x.Description,
            Email = x.Email,
            Id = x.Id,
            PhoneNumber = x.PhoneNumber
        }).ToList());

    }
}
