﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos.BannerDtos
{
    public class BannerResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? VideoDescription { get; set; }
        public string VideoUrl { get; set; } = default!;
    }
}
