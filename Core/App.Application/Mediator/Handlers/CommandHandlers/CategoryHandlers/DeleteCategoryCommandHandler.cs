using App.Application.Interfaces;
using App.Application.Mediator.Commands.CategoryCommands.Delete;
using App.Domain.Entities;
using MediatR;


namespace App.Application.Mediator.Handlers.CommandHandlers.CategoryHandlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;
        public DeleteCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }

    }
}
