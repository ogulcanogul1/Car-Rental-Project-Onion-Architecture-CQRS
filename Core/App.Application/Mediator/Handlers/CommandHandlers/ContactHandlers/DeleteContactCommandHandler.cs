using App.Application.Interfaces;
using App.Application.Mediator.Commands.ContactCommands.Delete;
using App.Domain.Entities;
using MediatR;
using System.Net;

namespace App.Application.Mediator.Handlers.CommandHandlers.ContactHandlers
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommandRequest>
    {
        private readonly IRepository<Contact> _repository;
        public DeleteContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteContactCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }


    }
}
