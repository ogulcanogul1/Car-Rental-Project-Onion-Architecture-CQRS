using App.Application.Interfaces;
using App.Application.Mediator.Commands.BrandCommands.Create;
using App.Domain.Entities.Cars;
using MediatR;

namespace App.Application.Mediator.Handlers.CommandHandlers.BrandHandlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
    {
        private readonly IRepository<Brand> _repository;

        public CreateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            Brand brand = new()
            {
                Name = request.Name
            };

            await _repository.CreateAsync(brand);

            return new CreateBrandCommandResponse(brand.Id);
        }

    }
}
