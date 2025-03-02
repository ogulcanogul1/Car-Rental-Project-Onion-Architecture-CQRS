using MediatR;

namespace App.Application.Mediator.Commands.ServiceCommands.Delete
{
    public class DeleteServiceCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
