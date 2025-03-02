using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.BannerQueries
{
    public class GetBannerQueryRequest : IRequest<List<GetBannerQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
