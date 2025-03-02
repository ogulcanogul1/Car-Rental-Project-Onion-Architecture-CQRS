using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.RentTypeQueries
{
    public class GetRentTypeByIdQueryRequest : IRequest<GetRentTypeByIdQueryResponse>
    {
        public GetRentTypeByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
