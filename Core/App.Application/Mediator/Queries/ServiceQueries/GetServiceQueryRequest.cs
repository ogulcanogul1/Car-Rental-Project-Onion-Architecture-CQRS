using MediatR;

namespace App.Application.Mediator.Queries.ServiceQueries
{
    public class GetServiceQueryRequest : IRequest<List<GetServiceQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
