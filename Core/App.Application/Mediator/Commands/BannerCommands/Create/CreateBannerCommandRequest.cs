using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.BannerCommands.Create
{
    public class CreateBannerCommandRequest : IRequest<CreateBannerCommandResponse>
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? VideoDescription { get; set; }
        public string VideoUrl { get; set; } = default!;
    }
}
