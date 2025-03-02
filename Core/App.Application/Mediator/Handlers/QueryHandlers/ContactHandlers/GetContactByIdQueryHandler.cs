using App.Application.Interfaces;
using App.Application.Mediator.Queries.ContactQueries;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Handlers.QueryHandlers.ContactHandlers
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQueryRequest, GetContactByIdQueryResponse>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResponse> Handle(GetContactByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Contact? contact = await _repository.GetByIdAsync(request.Id);

            return new()
            {
                Id = contact.Id,
                Email = contact.Email,
                Message = contact.Message,
                Name = contact.Name,
                SendDate = contact.SendDate,
                Subject = contact.Subject
            };
        }
    }
}
