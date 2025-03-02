using App.Application.Interfaces;
using App.Application.Mediator.Commands.CategoryCommands.Create;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest,CreateCategoryCommandResponse>
    {
        private readonly IRepository<Category> _repository;
        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category category = new()
            {
                Name = request.Name
            };
            await _repository.CreateAsync(category);

            return new(category.Id);
        }

    }
}
