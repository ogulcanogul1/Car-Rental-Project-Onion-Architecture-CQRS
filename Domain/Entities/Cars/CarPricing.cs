using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Cars
{
    public class CarPricing
    {
        public int Id { get; set; }
        public Car Car { get; set; } = default!;
        public int CarId { get; set; }
        public RentType RentType { get; set; } = default!;
        public int RentTypeId { get; set; }
        public double Amount { get; set; }
    }
}
