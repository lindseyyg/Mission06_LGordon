﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_LGordon.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
