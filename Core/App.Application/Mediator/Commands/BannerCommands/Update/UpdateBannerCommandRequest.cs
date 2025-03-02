using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.BannerCommands.Update;

public class UpdateBannerCommandRequest : IRequest
{
    public Banner Banner { get; set; } = default!;
}
