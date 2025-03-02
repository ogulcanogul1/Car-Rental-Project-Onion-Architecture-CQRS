using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQueryRequest : IRequest<List<GetSocialMediaQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
