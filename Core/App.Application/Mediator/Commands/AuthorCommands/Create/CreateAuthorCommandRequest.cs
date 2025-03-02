﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.AuthorCommands.Create
{
    public class CreateAuthorCommandRequest : IRequest<CreateAuthorCommandResponse>
    {
        public string Name { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
