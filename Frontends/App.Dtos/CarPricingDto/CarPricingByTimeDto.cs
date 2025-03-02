using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos.CarPricingDto
{
    public class CarPricingByTimeDto
    {
        public int Id { get; set; }
        public string Model { get; set; } = default!;
        public string? BigImageUrl { get; set; }
        public int Year { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; } = default!;
        public int BrandId { get; set; }

        public string Type { get; set; } = default!;
        public double Amount { get; set; }
    }
}
