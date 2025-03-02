using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Url { get; set; } = default!;
        public string IconUrl { get; set; } = default!;
    }
}
