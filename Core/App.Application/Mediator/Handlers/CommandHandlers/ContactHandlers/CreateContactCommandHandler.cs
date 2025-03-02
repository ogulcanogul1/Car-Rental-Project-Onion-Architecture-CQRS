using App.Application.Interfaces;
using App.Application.Mediator.Commands.ContactCommands.Create;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.ContactHandlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest,CreateContactCommandResponse>
    {

        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
        {
            Contact contact = new Contact
            {
                Email = request.Email,
                Message = request.Message,
                Name = request.Name,
                SendDate = request.SendDate,
                Subject = request.Subject
            };
            await _repository.CreateAsync(contact);

            return new(contact.Id);
        }

    }
}
