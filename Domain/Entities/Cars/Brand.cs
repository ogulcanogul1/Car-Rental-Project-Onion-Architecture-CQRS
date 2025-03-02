﻿namespace App.Domain.Entities.Cars
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Car>? Cars { get; set; }
    }
}
