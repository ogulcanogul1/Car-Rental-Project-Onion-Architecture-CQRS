using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQueryRequest : IRequest<List<GetFooterAddressQueryResponse>>
    {
        public bool Tracking { get; set; }
    }
}
