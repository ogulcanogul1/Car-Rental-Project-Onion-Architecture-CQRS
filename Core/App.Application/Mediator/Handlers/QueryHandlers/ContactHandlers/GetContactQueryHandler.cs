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
    public class GetContactQueryHandler : IRequestHandler<GetContactQueryRequest, List<GetContactQueryResponse>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public Task<List<GetContactQueryResponse>> Handle(GetContactQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                request = new() { Tracking = true };
            }
            return Task.FromResult(_repository.GetAll(request.Tracking).Select(x => new GetContactQueryResponse
            {
                Id = x.Id,
                Email = x.Email,
                Message = x.Message,
                Name = x.Name,
                SendDate = x.SendDate,
                Subject = x.Subject,
            }).ToList());
        }
    }
}
