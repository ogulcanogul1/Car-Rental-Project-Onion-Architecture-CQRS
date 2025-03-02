using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mediator.Commands.CategoryCommands.Update
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
