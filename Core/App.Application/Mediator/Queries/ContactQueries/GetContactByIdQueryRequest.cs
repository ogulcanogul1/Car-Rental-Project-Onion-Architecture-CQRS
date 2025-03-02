using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.ContactQueries
{
    public class GetContactByIdQueryRequest : IRequest<GetContactByIdQueryResponse>
    {
        public GetContactByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
