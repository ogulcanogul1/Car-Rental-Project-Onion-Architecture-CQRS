﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQueryRequest : IRequest<GetSocialMediaByIdQueryResponse>
    {
        public GetSocialMediaByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
