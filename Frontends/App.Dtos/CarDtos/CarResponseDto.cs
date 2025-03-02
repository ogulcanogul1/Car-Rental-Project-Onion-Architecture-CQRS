using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos.CarDtos
{
    public class CarResponseDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; } = default!;
        public string Model { get; set; } = default!;
        public int Year { get; set; }
        public double Km { get; set; }
        public string Transmisson { get; set; } = default!;
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; } = default!;
        public string BigImageUrl { get; set; } = default!;
    }
}
