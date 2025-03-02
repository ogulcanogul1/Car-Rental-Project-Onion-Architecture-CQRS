using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.CarQueries
{
    public class GetCarWithBrandByIdQueryRequest : IRequest<GetCarWithBrandByIdQueryResponse>
    {
        public GetCarWithBrandByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
