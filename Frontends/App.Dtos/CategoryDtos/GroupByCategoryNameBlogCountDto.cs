using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos.CategoryDtos
{
    public class GroupByCategoryNameBlogCountDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public int BlogCount { get; set; }
    }
}
