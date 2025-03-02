using App.Application.Interfaces;
using App.Application.Mediator.Commands.FooterAddressCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.FooterAddressHandlers
{
    public class DeleteFooterAddressCommandHandler : IRequestHandler<DeleteFooterAddressCommandRequest>
    {
        private readonly IRepository<FooterAddress> _repository;

        public DeleteFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteFooterAddressCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
