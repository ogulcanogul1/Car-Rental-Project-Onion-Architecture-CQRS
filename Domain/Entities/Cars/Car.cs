using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Cars
{
    public class Car
    {
        public int Id { get; set; }
        public Brand Brand { get; set; } = default!;
        public int BrandId { get; set; }
        public string Model { get; set; } = default!;
        public int Year { get; set; }
        public double Km { get; set; }
        public string Transmisson { get; set; } = default!;
        public byte Seat { get; set; }
        public byte Luggage  { get; set; }
        public string Fuel { get; set; } = default!;
        public string BigImageUrl { get; set; } = default!;
        public List<CarPricing>? CarPricings { get; set; }
        public List<CarFeature>? CarFeatures { get; set; }

        public CarDescription? CarDescription { get; set; }

    }
}
