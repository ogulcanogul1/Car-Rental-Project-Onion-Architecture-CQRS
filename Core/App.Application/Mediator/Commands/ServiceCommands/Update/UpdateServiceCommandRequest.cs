using MediatR;

namespace App.Application.Mediator.Commands.ServiceCommands.Update
{
    public class UpdateServiceCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? IconUrl { get; set; } = default!;
    }
}
