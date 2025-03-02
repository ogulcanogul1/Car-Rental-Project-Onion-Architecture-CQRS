using App.Application.Interfaces;
using App.Application.Mediator.Commands.ContactCommands.Update;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.ContactHandlers
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommandRequest>
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
        {
            Contact contact = new()
            {
                Email = request.Email,
                Id = request.Id,
                Message = request.Message,
                Name = request.Name,
                SendDate = request.SendDate,
                Subject = request.Subject
            };
            await _repository.UpdateAsync(contact);
        }
    }
}
