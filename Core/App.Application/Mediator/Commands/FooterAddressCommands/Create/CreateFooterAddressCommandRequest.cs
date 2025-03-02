using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.FooterAddressCommands.Create
{
    public class CreateFooterAddressCommandRequest : IRequest<CreateFooterAddressCommandResponse>
    {
        public string Description { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
