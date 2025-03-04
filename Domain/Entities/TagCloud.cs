﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class TagCloud
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public int BlogId { get; set; }
        public Blog? Blog { get; set; } 
    }
}
