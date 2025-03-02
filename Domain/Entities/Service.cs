using App.Domain.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? IconUrl { get; set; } = default!;
    }

//    .flaticon-wedding-car:before { content: "\f100"; }
//.flaticon - car:before { content: "\f101"; }
//.flaticon - suv:before { content: "\f102"; }
//.flaticon - transportation:before { content: "\f103"; }
//.flaticon - route:before { content: "\f104"; }
//.flaticon - handshake:before { content: "\f105"; }
//.flaticon - rent:before { content: "\f106"; }
//.flaticon - dashboard:before { content: "\f107"; }
//.flaticon - pistons:before { content: "\f108"; }
//.flaticon - car - seat:before { content: "\f109"; }
//.flaticon - backpack:before { content: "\f10a"; }
//.flaticon - diesel:before { content: "\f10b"; }
}
