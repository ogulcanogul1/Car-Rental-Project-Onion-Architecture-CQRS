using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.AboutQueries
{
    public class GetAboutByIdQueryRequest : IRequest<GetAboutByIdQueryResponse>
    {
        public GetAboutByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}
