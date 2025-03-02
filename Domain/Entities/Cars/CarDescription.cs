using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Cars
{
    public class CarDescription
    {
        public int Id { get; set; }
        public Car Car { get; set; } = default!;
        public int CarId { get; set; }
        public string Details { get; set; } = default!;
    }
}
