namespace App.Application.Mediator.Commands.AboutCommands.Create
{
    public class CreateAboutCommandResponse
    {
        public CreateAboutCommandResponse(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
