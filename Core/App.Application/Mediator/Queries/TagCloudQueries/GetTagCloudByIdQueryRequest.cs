using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQueryRequest : IRequest<GetTagCloudGetByIdQueryResponse>
    {
        public GetTagCloudByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
