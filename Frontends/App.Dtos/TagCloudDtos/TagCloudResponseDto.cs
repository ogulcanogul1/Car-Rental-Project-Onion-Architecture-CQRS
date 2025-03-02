using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos.TagCloudDtos
{
    public class TagCloudResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public int BlogId { get; set; }
    }
}
