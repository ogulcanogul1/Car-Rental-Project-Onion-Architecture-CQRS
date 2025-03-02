using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime CreatedDate { get; set; }
        public string? Description { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; } = default!;
    }
}
