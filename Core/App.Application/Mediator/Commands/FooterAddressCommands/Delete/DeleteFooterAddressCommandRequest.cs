using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.FooterAddressCommands.Delete
{
    public class DeleteFooterAddressCommandRequest: IRequest
    {
        public int Id { get; set; }
    }
}
