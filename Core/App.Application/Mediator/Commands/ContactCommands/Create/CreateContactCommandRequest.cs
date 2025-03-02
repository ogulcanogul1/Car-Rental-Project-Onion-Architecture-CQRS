using MediatR;

namespace App.Application.Mediator.Commands.ContactCommands.Create
{
    public class CreateContactCommandRequest : IRequest<CreateContactCommandResponse>
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Subject { get; set; } = default!;
        public string Message { get; set; } = default!;
        public DateTime SendDate { get; set; }
    }
}
