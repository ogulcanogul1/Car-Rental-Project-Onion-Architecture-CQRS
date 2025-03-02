using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Url { get; set; } = default!;
        public string IconUrl { get; set; } = default!;
    }
}
