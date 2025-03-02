using App.Domain.Entities.Enumarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Cars
{
    public class RentType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<CarPricing>? CarPricings { get; set; }
    }
}
