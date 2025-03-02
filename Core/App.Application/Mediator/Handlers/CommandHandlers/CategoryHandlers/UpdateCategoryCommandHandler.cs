using App.Application.Interfaces;
using App.Application.Mediator.Commands.CategoryCommands.Update;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;
        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category category = new Category
            {
                Id = request.Id,
                Name = request.Name
            };
            await _repository.UpdateAsync(category);
        }
    }
}
