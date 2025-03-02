using App.Application.Interfaces;
using App.Application.Mediator.Commands.SocialMediaCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommandRequest, CreateSocialMediaCommandResponse>
    {
        private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<CreateSocialMediaCommandResponse> Handle(CreateSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            SocialMedia media = new SocialMedia
            {
                IconUrl = request.IconUrl,
                Name = request.Name,
                Url = request.Url
            };
            await _repository.CreateAsync(media);
            return new() { Id = media.Id };
        }
    }
}
