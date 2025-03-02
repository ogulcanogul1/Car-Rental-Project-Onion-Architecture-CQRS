using MediatR;

namespace App.Application.Mediator.Commands.AboutCommands.Create
{
    public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
