using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Cars
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<CarFeature>? CarFeatures { get; set; }
    }
}
