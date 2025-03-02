using App.Application.Interfaces;
using App.Application.Mediator.Queries.SocialMediaQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQueryRequest, GetSocialMediaByIdQueryResponse>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResponse> Handle(GetSocialMediaByIdQueryRequest request, CancellationToken cancellationToken)
        {
            SocialMedia? media = await _repository.GetByIdAsync(request.Id);
            if (media == null) { }

            return new()
            {
                Id = media.Id,
                IconUrl = media.IconUrl,
                Name = media.Name,
                Url = media.Url
            };
        }
    }
}
