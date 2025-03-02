using App.Application.Interfaces;
using App.Application.Mediator.Commands.BrandCommands.Update;
using App.Domain.Entities.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.CommandHandlers.BrandHandlers
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest>
    {

        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(new()
            {
                Id = request.Id,
                Name = request.Name
            });
        }
    }
}
