using App.Application.Interfaces;
using App.Application.Mediator.Commands.FooterAddressCommands.Create;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.FooterAddressHandlers
{
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommandRequest, CreateFooterAddressCommandResponse>
    {
        private readonly IRepository<FooterAddress> _repository;

        public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<CreateFooterAddressCommandResponse> Handle(CreateFooterAddressCommandRequest request, CancellationToken cancellationToken)
        {
            FooterAddress footerAddress = new FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            await _repository.CreateAsync(footerAddress);
            return new() { Id = footerAddress.Id };
        }
    }
}
