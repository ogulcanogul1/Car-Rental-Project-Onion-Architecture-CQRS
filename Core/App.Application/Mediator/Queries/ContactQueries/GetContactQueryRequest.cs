using MediatR;

namespace App.Application.Mediator.Queries.ContactQueries
{
    public class GetContactQueryRequest : IRequest<List<GetContactQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
